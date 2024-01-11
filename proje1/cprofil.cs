using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace proje1
{
	public partial class cprofil : DevExpress.XtraEditors.XtraForm
	{
        
        private string connectionString = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        OpenFileDialog dosyaSec = new OpenFileDialog();
        private string secilenDosyaYolu;
        public cprofil()
		{
			InitializeComponent();
		}
        private byte[] DosyaBinaryAl(string dosyaYolu)
        {
            if (!string.IsNullOrEmpty(dosyaYolu))
            {
                return File.ReadAllBytes(dosyaYolu);
            }
            return null;
        }
        private void SqlBaglan()
        {
            string GonderenKullanicii;
            Image resim = Image.FromFile(dosyaSec.FileName);
            pictureEdit2.Image = resim;
            secilenDosyaYolu = dosyaSec.FileName;
            GonderenKullanicii = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
            try
            {
                string query = "UPDATE KULKARTT SET KULPROFIL = @YeniProfil WHERE KULADI = @GonderenKullanici";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GonderenKullanici", GonderenKullanicii);

                        string resimDosyaYolu = secilenDosyaYolu;
                        byte[] resimBinary = DosyaBinaryAl(resimDosyaYolu);

                        if (resimBinary != null)
                        {
                            SqlParameter param = new SqlParameter("@YeniProfil", SqlDbType.VarBinary, -1);
                            param.Value = resimBinary;
                            command.Parameters.Add(param);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@YeniProfil", DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Profil fotoğrafınız başarıyla güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Sistem kaynaklı bir hata yüzünden şuan güncelleme yapamıyoruz...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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

		private void simpleButton2_Click(object sender, EventArgs e)
		{
            try
            {
                DosyaYoluAl();
            }
			catch { }
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
            try
            {
                SqlBaglan();
            }
            catch { }
        }
	}
}
