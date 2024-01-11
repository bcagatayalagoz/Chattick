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

	public partial class ccep : DevExpress.XtraEditors.XtraForm
	{
        private string connectionString = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        public ccep()
		{
			InitializeComponent();
		}
        private void SqlBaglan()
        {
            try
            {
                string query = "UPDATE KULKARTT SET KULCEP = @YeniCep WHERE KULCEP = @EskiCep";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@YeniCep", kulyenicep.Text.Trim());
                        command.Parameters.AddWithValue("@EskiCep", kuleskicep.Text.Trim());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Sistem kaynaklı bir hata yüzünden şuan güncelleme yapamıyoruz...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

		private void simpleButton1_Click(object sender, EventArgs e)
		{
            try
            {
                if (kullanıcıbil.KullaniciBilgileri.KullanıcıCep == kuleskicep.Text && kulyenicep.Text == kulyenicep2.Text)
                {
                    SqlBaglan();
                    MessageBox.Show("Cep Telefonunuz başarıyla güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eski Cep Telefonu veya yeni Cep Telefonu eşleşmiyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
			catch { }
        }
	}
}
