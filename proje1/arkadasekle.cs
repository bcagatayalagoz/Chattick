using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje1
{
    public partial class arkadasekle : DevExpress.XtraEditors.XtraForm
    {
        public static List<string> eklenenArkadaslar = new List<string>();
        
        public string connectionString = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        public arkadasekle()
        {
            InitializeComponent();
            KullanicilariGetir();
            
        }
        public void KullanicilariGetir()
        {
            try
            {
                
                string query = "SELECT KULADI FROM KULKARTT";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string kullaniciAdi = reader["KULADI"].ToString();
                            listBoxControl1.Items.Add(kullaniciAdi);
                        }

                        reader.Close();
                    }
                }
            }
            catch { }
        }
        public class Kisi
        {
            public string Ad { get; set; }

            public Kisi(string ad)
            {
                Ad = ad;
            }
        }
		private void simpleButton1_Click(object sender, EventArgs e)
		{
            try
            {
                if (listBoxControl1.SelectedItem != null)
                {
                    string secilenKisi2 = listBoxControl1.SelectedItem.ToString();
                    kullanıcıbil.KullaniciBilgileri.SecilenKisi = listBoxControl1.SelectedItem.ToString();

                    if (!eklenenArkadaslar.Contains(secilenKisi2))
                    {
                        anasayfa anasayfaForm = Application.OpenForms["anasayfa"] as anasayfa;

                        if (anasayfaForm != null)
                        {
                            try
                            {
                                

                                eklenenArkadaslar.Add(secilenKisi2);
                              
                                this.Close();

                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        connection.Open();

                                        string insertQuery = "INSERT INTO Arkadaslar (KULADI, EKLEYENNO,EKLENENNO) VALUES (@KULADI, @EKLEYENNO, @EKLENENNO)";
                                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                        {
                                            insertCmd.Parameters.AddWithValue("@KULADI", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);
                                            insertCmd.Parameters.AddWithValue("@EKLEYENNO", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);
                                            insertCmd.Parameters.AddWithValue("@EKLENENNO", kullanıcıbil.KullaniciBilgileri.SecilenKisi);
                                            insertCmd.ExecuteNonQuery();
                                        }

                                        MessageBox.Show("Arkadaş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        anasayfa mainForm = Application.OpenForms["MainForm"] as anasayfa;
                                        if (mainForm != null)
                                        {
                                            mainForm.KullanıcıGetir(secilenKisi2);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu kişi zaten eklenmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kişi seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
		{
                try
                {
                    if (listBoxControl1.SelectedItem != null)
                    {
                        string secilenKisi = listBoxControl1.SelectedItem.ToString();

                        if (!eklenenArkadaslar.Contains(secilenKisi))
                        {
                            anasayfa anasayfaForm = Application.OpenForms["anasayfa"] as anasayfa;

                            if (anasayfaForm != null)
                            {
                                try
                                {

                                    anasayfaForm.EklemeYap(secilenKisi);
                                }
                                catch
                                {

                                }

                                eklenenArkadaslar.Add(secilenKisi);
                                
                                this.Close();

                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        connection.Open();

                                        string insertQuery = "INSERT INTO Arkadaslar (KULADI, EKLEYENNO,EKLENENNO) VALUES (@KULADI, @EKLEYENNO, @EKLENENNO)";
                                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                        {
                                            insertCmd.Parameters.AddWithValue("@KULADI", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);
                                            insertCmd.Parameters.AddWithValue("@EKLEYENNO", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);
                                            insertCmd.Parameters.AddWithValue("@EKLENENNO", secilenKisi);
                                            insertCmd.ExecuteNonQuery();
                                        }

                                        MessageBox.Show("Arkadaş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        anasayfa mainForm = Application.OpenForms["MainForm"] as anasayfa;
                                        if (mainForm != null)
                                        {

                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu kişi zaten eklenmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir kişi seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }

            }
        }
	}





