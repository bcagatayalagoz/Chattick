using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System.IO;

namespace proje1
{
    public partial class kaydol : DevExpress.XtraEditors.XtraForm
    {
        OpenFileDialog dosyaSec = new OpenFileDialog();
        private string secilenDosyaYolu;
        
        public kaydol()
        {
            InitializeComponent();

        }

        private void kaydol_Load(object sender, EventArgs e)
        {
            kuladi.TabIndex = 0;
            kuladi.TabStop = true;

            kulmail.TabIndex = 1;
            kulmail.TabStop = true;

            kulcep.TabIndex = 2;
            kulcep.TabStop = true;

            kulsifre.TabIndex = 3;
            kulsifre.TabStop = true;

            kaydolbuton1.TabIndex = 4;
            kaydolbuton1.TabStop = true;
        }
        private byte[] DosyaBinaryAl(string dosyaYolu)
        {
            if (!string.IsNullOrEmpty(dosyaYolu))
            {
                return File.ReadAllBytes(dosyaYolu);
            }
            return null;
        }
        private string DosyaYoluAl()
        {

            string dosyaYolu = string.Empty;


            dosyaSec.Filter = "Resim Dosyaları |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            dosyaSec.FilterIndex = 1;
            dosyaSec.RestoreDirectory = true;

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                Image resim = Image.FromFile(dosyaSec.FileName);
                pictureEdit2.Image = resim;
                secilenDosyaYolu = dosyaSec.FileName; 

            }

            return dosyaYolu;
        }
        private void SqlGonder()
        {
            try
            {
                string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
                SqlConnection baglanti = new SqlConnection(connectionstring);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO KULKARTT (KULADI, KULKOD, KULMAIL, KULCEP, KULPROFIL) values (@KULADI, @KULKOD, @KULMAIL, @KULCEP, @KULPROFIL)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@KULADI", kuladi.Text);
                    komut.Parameters.AddWithValue("@KULKOD", kulsifre.Text);
                    komut.Parameters.AddWithValue("@KULMAIL", kulmail.Text);
                    komut.Parameters.AddWithValue("@KULCEP", kulcep.Text);

                    string resimDosyaYolu = secilenDosyaYolu;
                    byte[] resimBinary = DosyaBinaryAl(resimDosyaYolu);


                    if (resimBinary != null)
                    {
                        SqlParameter param = new SqlParameter("@KULPROFIL", SqlDbType.VarBinary, -1);
                        param.Value = resimBinary;
                        komut.Parameters.Add(param);
                    }
                    else
                    {

                        komut.Parameters.AddWithValue("@KULPROFIL", DBNull.Value);
                    }

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            catch { }
        }
        private void kaydolbuton1_Click(object sender, EventArgs e)
        {

            secilenDosyaYolu = dosyaSec.FileName;
            kullanıcıbil.KullaniciBilgileri.KullanıcıProfil = secilenDosyaYolu;
            kullanıcıbil.KullaniciBilgileri.KullanıcıMail = kulmail.Text;
            kullanıcıbil.KullaniciBilgileri.KullanıcıCep = kulcep.Text;


            string kulladi = kuladi.Text;
            string sifree = kulsifre.Text;
            try
            {
                if (kulmail.Text.Contains("@") && (kulmail.Text.EndsWith("gmail.com") || kulmail.Text.EndsWith("hotmail.com") || kulmail.Text.EndsWith("yahoo.com") || kulmail.Text.EndsWith("outlook.com") || kulmail.Text.EndsWith("karatay.edu.tr"))) { }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (kuladi.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kuladi.Text.Length <= 5)
                {
                    MessageBox.Show("Kullanıcı adı 5 karakterden küçük olamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kuladi.Text.Length > 14)
                {
                    MessageBox.Show("Kullanıcı adı 14 karakterden büyük olamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulmail.Text == "")
                {
                    MessageBox.Show("E-Mail boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulcep.Text == "")
                {
                    MessageBox.Show("Cep telefonu boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulcep.Text.Length > 11)
                {
                    MessageBox.Show("Lütfen geçerli bir numara giriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulcep.Text.Length < 11)
                {
                    MessageBox.Show("Lütfen geçerli bir numara giriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulsifre.Text == "")
                {
                    MessageBox.Show("Şifre boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulsifre.Text.Length <= 5)
                {
                    MessageBox.Show("Şifre 5 karakterden küçük olamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kulsifre.Text.Length > 14)
                {
                    MessageBox.Show("Şifre 14 karakterden büyük olamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SqlGonder();
                            MessageBox.Show("Kullanıcı adınız: " + kulladi + "\n" + "Şifreniz: " + sifree + "\n" + "Hoşgeldiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Hata oluştu, Lütfen daha sonra tekrar deneyiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (result == DialogResult.No)
                    {

                    }

                }
            }
            catch { }
        }

        private void girisdon_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            catch { }
        }

		private void simpleButton1_Click(object sender, EventArgs e)
		{
            try
            {
                DosyaYoluAl();
            }
            catch { }
        }

		private void kaydol_FormClosing(object sender, FormClosingEventArgs e)
		{
            try
            {
                Application.Exit();
            }
			catch { }
		}
	}
}    
    

