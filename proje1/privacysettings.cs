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
	public partial class privacysettings : DevExpress.XtraEditors.XtraForm
	{
        public string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        public enum Profil
        {
            Herkes,
            SadeceArkadaslar,
            SadeceBen
        }
        public enum Grup
        {
            Herkes,
            SadeceArkadaslar,
            SadeceBen
        }
        public enum Mesaj
        {
            Herkes,
            SadeceArkadaslar,
            SadeceBen
        }
        public enum SonCevrim
        {
            Herkes,
            SadeceArkadaslar,
            SadeceBen
        }

        protected void ProfilChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = (string)comboBoxEdit3.SelectedItem;

                Profil selectedOption;

                if (selectedValue == "Herkes")
                {
                    selectedOption = Profil.Herkes;
                }
                else if (selectedValue == "Sadece Arkadaşlar")
                {
                    selectedOption = Profil.SadeceArkadaslar;
                }
                else if (selectedValue == "Sadece Ben")
                {
                    selectedOption = Profil.SadeceBen;
                }
                else
                {

                    selectedOption = Profil.Herkes;
                }


                if (selectedOption == Profil.Herkes)
                {

                }
                else if (selectedOption == Profil.SadeceArkadaslar)
                {

                }
                else if (selectedOption == Profil.SadeceBen)
                {

                }
            }
			catch { }
          
        }
        protected void GrupChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = (string)comboBoxEdit4.SelectedItem;

                Grup selectedOption;

                if (selectedValue == "Herkes")
                {
                    selectedOption = Grup.Herkes;
                }
                else if (selectedValue == "Sadece Arkadaşlar")
                {
                    selectedOption = Grup.SadeceArkadaslar;
                }
                else if (selectedValue == "Sadece Ben")
                {
                    selectedOption = Grup.SadeceBen;
                }
                else
                {

                    selectedOption = Grup.Herkes;
                }


                if (selectedOption == Grup.Herkes)
                {

                }
                else if (selectedOption == Grup.SadeceArkadaslar)
                {

                }
                else if (selectedOption == Grup.SadeceBen)
                {

                }
            }
			catch { }
        }
        protected void MesajChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = (string)comboBoxEdit1.SelectedItem;

                Mesaj selectedOption;

                if (selectedValue == "Herkes")
                {
                    selectedOption = Mesaj.Herkes;
                }
                else if (selectedValue == "Sadece Arkadaşlar")
                {
                    selectedOption = Mesaj.SadeceArkadaslar;
                }
                else if (selectedValue == "Sadece Ben")
                {
                    selectedOption = Mesaj.SadeceBen;
                }
                else
                {

                    selectedOption = Mesaj.Herkes;
                }


                if (selectedOption == Mesaj.Herkes)
                {

                }
                else if (selectedOption == Mesaj.SadeceArkadaslar)
                {

                }
                else if (selectedOption == Mesaj.SadeceBen)
                {

                }
            }
			catch { }
           
        }
        protected void SonCevrimChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = (string)comboBoxEdit2.SelectedItem;

                SonCevrim selectedOption;

                if (selectedValue == "Herkes")
                {
                    selectedOption = SonCevrim.Herkes;
                }
                else if (selectedValue == "Sadece Arkadaşlar")
                {
                    selectedOption = SonCevrim.SadeceArkadaslar;
                }
                else if (selectedValue == "Sadece Ben")
                {
                    selectedOption = SonCevrim.SadeceBen;
                }
                else
                {

                    selectedOption = SonCevrim.Herkes;
                }


                if (selectedOption == SonCevrim.Herkes)
                {

                }
                else if (selectedOption == SonCevrim.SadeceArkadaslar)
                {

                }
                else if (selectedOption == SonCevrim.SadeceBen)
                {

                }
            }
			catch { }
        }
        public void SqlBaglan()
        {
            try
            {
                string query = "UPDATE KULKARTT SET PROFIL = @Profil, GRUP = @Grup, KIMMESAJ = @Mesaj, SONCEVRIM = @SonCevrim WHERE KULADI = @KulAdi";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mesaj", comboBoxEdit1.EditValue);
                        command.Parameters.AddWithValue("@SonCevrim", comboBoxEdit2.EditValue);
                        command.Parameters.AddWithValue("@Profil", comboBoxEdit3.EditValue);
                        command.Parameters.AddWithValue("@Grup", comboBoxEdit4.EditValue);
                        command.Parameters.AddWithValue("@KulAdi", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Tercihleriniz başarıyla kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch 
            {
                
            }

        }
        public privacysettings()
		{
			InitializeComponent();
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
