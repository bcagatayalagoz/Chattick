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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        
        public Form1()
        {
                   
            InitializeComponent();
            
        }
  
        private void SqlBaglan()
        {
            try
            {
                string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
                string query = "SELECT KULADI, KULKOD FROM PROJEVERİ2023..KULKARTT WHERE KULADI = @KULADI AND KULKOD = @KULKOD";
                

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KULADI", kuladi.Text.Trim());
                        command.Parameters.AddWithValue("@KULKOD", kulsifre.Text.Trim());

                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (kuladi.Text == "")
                            {
                                MessageBox.Show("Kullanıcı adı boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (kulsifre.Text == "")
                            {
                                MessageBox.Show("Şifre boş bırakılamaz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (dr.Read())
                                {
                                    kullanıcıbil.KullaniciBilgileri.GonderenKullanici = kuladi.Text;
                                    kullanıcıbil.KullaniciBilgileri.KullanıcıSifre = kulsifre.Text;
                                    this.Hide();
                                    anasayfa f = new anasayfa();
                                    f.Show();
                                    dr.Close();

                                   
                                    string updateQuery = "UPDATE PROJEVERİ2023..KULKARTT SET CEVRIMICI = 1 WHERE KULADI = @KULADI";

                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@KULADI", kuladi.Text.Trim());
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    dr.Close();
                                    MessageBox.Show("Kullanıcı Kodu veya Şifre Yanlış...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kuladi.TabIndex = 0;
            kuladi.TabStop = true;

            kulsifre.TabIndex = 1;
            kulsifre.TabStop = true;

            girisbuton.TabIndex = 2;
            girisbuton.TabStop = true;

            kaydolbuton.TabIndex = 3;
            kaydolbuton.TabStop = true;
        }
       


        private void girisbuton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglan();
            }
            catch { }
        }


        private void kuladi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                girisbuton.PerformClick();
            }
        }
          
        private void kaydolbuton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                kaydol f = new kaydol();
                f.Show();
            }
            catch { }


        }

        private void kulsifre_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                girisbuton.PerformClick();
            }
        }
    }
}



