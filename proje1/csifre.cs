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
    public partial class csifre : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";

        public csifre()
        {
            InitializeComponent();
        }

        private void SqlBaglan()
        {
            try
            {
                string query = "UPDATE KULKARTT SET KULKOD = @YeniSifre WHERE KULKOD = @EskiSifre";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@YeniSifre", kulyenisifre.Text.Trim());
                        command.Parameters.AddWithValue("@EskiSifre", kuleskisifre.Text.Trim());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sistem kaynaklı bir hata yüzünden güncelleme yapamıyoruz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kullanıcıbil.KullaniciBilgileri.KullanıcıSifre == kuleskisifre.Text && kulyenisifre.Text == kulyenisifre2.Text)
                {
                    SqlBaglan();
                    MessageBox.Show("Şifreniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eski şifre veya yeni şifreler eşleşmiyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch { }
            
        }

		private void csifre_Load(object sender, EventArgs e)
		{
            kuleskisifre.TabIndex = 0;
            kuleskisifre.TabStop = true;

            kulyenisifre.TabIndex = 1;
            kulyenisifre.TabStop = true;

            kulyenisifre2.TabIndex = 2;
            kulyenisifre2.TabStop = true;

            simpleButton1.TabIndex = 3;
            simpleButton1.TabStop = true;
        }

		private void kuleskisifre_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                simpleButton1.PerformClick();
            }
        }

		private void kulyenisifre_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                simpleButton1.PerformClick();
            }
        }

		private void kulyenisifre2_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                simpleButton1.PerformClick();
            }
        }
	}
}

