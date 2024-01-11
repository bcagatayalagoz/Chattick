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
	public partial class ckulad : DevExpress.XtraEditors.XtraForm
	{
        private string connectionString = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        public ckulad()
		{
			InitializeComponent();
		}
        private void SqlBaglan()
        {
            try
            {
                string query = "UPDATE KULKARTT SET KULADI = @YeniAd WHERE KULADI = @EskiAd";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@YeniAd", kulyeniad.Text.Trim());
                        command.Parameters.AddWithValue("@EskiAd", kuleskiad.Text.Trim());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Sistem kaynaklı bir hata yüzünden güncelleme yapamıyoruz...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
		{
            try
            {
                if (kullanıcıbil.KullaniciBilgileri.GonderenKullanici == kuleskiad.Text && kulyeniad.Text == kulyeniad2.Text)
                {
                    SqlBaglan();
                    MessageBox.Show("Kullanıcı adınız başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eski kullanıcı adı veya yeni adlar eşleşmiyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
			catch { }
        }
	}
}
