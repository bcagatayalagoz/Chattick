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
using DevExpress.XtraBars.Navigation;
using Newtonsoft.Json;
using System.IO;
using System.Media;



namespace proje1
{
    public partial class anasayfa : DevExpress.XtraEditors.XtraForm


    {
        public string secilenKisi2 = kullanıcıbil.KullaniciBilgileri.SecilenKisi;
        private Dictionary<string, Form> chatForms = new Dictionary<string, Form>();
        private Dictionary<string, Form> chatGrups = new Dictionary<string, Form>();
        public string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";
        private void MesajGeldiBildirimiGoster(string gonderen, string icerik)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.chattick.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);
                Bitmap bitmap = new Bitmap(ms);
                Icon chatIcon2 = Icon.FromHandle(bitmap.GetHicon());
                notifyIcon2.Icon = chatIcon2;


                string bildirimBasligi = $"Yeni Mesaj - {gonderen}";
                string bildirimMetni = $"Yeni mesajınız var: {icerik}";

                notifyIcon2.BalloonTipTitle = bildirimBasligi;
                notifyIcon2.BalloonTipText = bildirimMetni;
                notifyIcon2.ShowBalloonTip(3000);
            }
            catch { }
        }
        public anasayfa()
        {
            string gonderen2 = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
            string gonderen = kullanıcıbil.KullaniciBilgileri.AliciKullanici;
            string icerik = "Bu bir mesaj içeriğidir.";
            InitializeComponent();
            MesajGeldiBildirimiGoster2(gonderen2);
            MesajGeldiBildirimiGoster(gonderen, icerik);
            KullanıcıGetir(secilenKisi2);

        }
       
        private void MesajGeldiBildirimiGoster2(string gonderen)
        {
            try
            {
                MemoryStream ms1 = new MemoryStream();
                Properties.Resources.chattick.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                ms1.Seek(0, SeekOrigin.Begin);


                Bitmap bitmap1 = new Bitmap(ms1);


                Icon chatIcon = Icon.FromHandle(bitmap1.GetHicon());
                notifyIcon1.Icon = chatIcon;
                string bildirimBasligi = $"Hoşgeldiniz - {gonderen} !";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                string bildirimMetni = "Mutlu günler geçirmenizi dileriz!";

                notifyIcon1.BalloonTipTitle = bildirimBasligi;
                notifyIcon1.BalloonTipText = bildirimMetni;
                notifyIcon1.ShowBalloonTip(3000);
            }
            catch
            {
            }
        }
        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            anasayfa f = new anasayfa();
            this.Hide();
            f.Show();


        }
        public void KullanıcıGetir(string secilenKisi2)
        {


            using (SqlConnection connection1 = new SqlConnection(connectionstring))
            {
                string sorgu = "SELECT EKLENENNO FROM Arkadaslar WHERE EKLEYENNO = @EKLEYENNO";
                using (SqlCommand komut = new SqlCommand(sorgu, connection1))
                {

                    komut.Parameters.AddWithValue("@EKLEYENNO", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);
                    connection1.Open();

                    SqlDataReader okuyucu = komut.ExecuteReader();


                    while (okuyucu.Read())
                    {
                        string arkadasAdi = okuyucu["EKLENENNO"].ToString();
                        AccordionControlElement element = new AccordionControlElement();
                        element.Text = arkadasAdi;
                        element.Style = ElementStyle.Item;
                        element.Appearance.Default.BackColor = Color.DimGray;
                        element.Appearance.Default.BackColor2 = Color.DimGray;
                        element.Appearance.Default.BorderColor = Color.White;
                        element.Appearance.Default.ForeColor = Color.White;
                        if (!arkadasekle.eklenenArkadaslar.Contains(arkadasAdi))
                        {
                            element.Click += (sender, e) =>
                            {
                                Form yeniChatForm = new Form();
                                yeniChatForm.Text = $"ChatTick - {arkadasAdi}";
                                yeniChatForm.Size = new Size(400, 300);

                                string kullaniciTabloAdi = "Mesajlar_" + arkadasAdi;

                                using (SqlConnection connection = new SqlConnection(connectionstring))
                                {
                                    connection.Open();

                                    string checkTableQuery = $"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{kullaniciTabloAdi}') BEGIN " +
                                        $"CREATE TABLE {kullaniciTabloAdi} (MesajID INT PRIMARY KEY IDENTITY, MesajMetni NVARCHAR(MAX), GonderenKullanici NVARCHAR(100), AliciKullanici NVARCHAR(100), Tarih DATETIME) END";

                                    using (SqlCommand command = new SqlCommand(checkTableQuery, connection))
                                    {
                                        try
                                        {
                                            command.ExecuteNonQuery();

                                        }
                                        catch
                                        {

                                        }
                                    }
                                }



                                var topPanel = new TableLayoutPanel();
                                topPanel.ColumnCount = 2;
                                topPanel.RowCount = 2;
                                topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                                topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                                topPanel.Dock = DockStyle.Top;

                                byte[] resimBinary = null;


                                using (SqlConnection connection = new SqlConnection(connectionstring))
                                {
                                    string query = "SELECT KULPROFIL FROM KULKARTT WHERE KULADI = @KULADI";
                                    using (SqlCommand command = new SqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@KULADI", arkadasAdi);

                                        connection.Open();
                                        resimBinary = command.ExecuteScalar() as byte[];
                                    }
                                }


                                if (resimBinary != null)
                                {
                                    using (MemoryStream stream = new MemoryStream(resimBinary))
                                    {
                                        Image resim = Image.FromStream(stream);
                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                        pictureBox.Image = resim;

                                        topPanel.Controls.Add(pictureBox, 0, 0);
                                    }
                                }

                                var nameLabel = new Label();
                                nameLabel.Text = arkadasAdi;
                                nameLabel.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                                nameLabel.Dock = DockStyle.Top;
                                nameLabel.AutoSize = true;

                                var lastSeenLabel = new Label();
                                lastSeenLabel.Font = new Font("Times New Roman", 10);
                                lastSeenLabel.Dock = DockStyle.Top;
                                lastSeenLabel.AutoSize = true;
                                topPanel.Controls.Add(nameLabel, 1, 0);
                                topPanel.Controls.Add(lastSeenLabel, 1, 1);
                                DateTime sonGorulmeZamani;
                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionstring))
                                    {
                                        string query = "SELECT CEVRIMICI, SONGORULME FROM KULKARTT WHERE KULADI = @KULADI";

                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            command.Parameters.AddWithValue("@KULADI", arkadasAdi);

                                            connection.Open();
                                            SqlDataReader reader = command.ExecuteReader();

                                            if (reader.Read())
                                            {
                                                int cevrimiciDurum = 0;
                                                string cevrimiciValue = reader.GetString(0);

                                                if (int.TryParse(cevrimiciValue, out cevrimiciDurum))
                                                {
                                                    if (cevrimiciDurum == 1)
                                                    {
                                                        lastSeenLabel.Text = "Çevrimiçi";
                                                    }
                                                    else if (!reader.IsDBNull(1) && DateTime.TryParse(reader["SONGORULME"].ToString(), out sonGorulmeZamani))
                                                    {
                                                        lastSeenLabel.Text = "Son Görülme: " + sonGorulmeZamani.ToString();
                                                    }
                                                }
                                            }

                                            reader.Close();
                                        }
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Kullanıcı kayıtlı olmasına rağmen daha önce programa giriş yapmadığını bilginize sunarız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                                flowLayout.FlowDirection = FlowDirection.TopDown;
                                flowLayout.Dock = DockStyle.Top;
                                flowLayout.Height = 500;


                                Panel panel1 = new Panel();
                                panel1.Dock = DockStyle.Bottom;
                                panel1.Height = 40;




                                Button actionButton = new Button();
                                actionButton.Text = "...";
                                actionButton.Size = new Size(30, 30);
                                actionButton.Location = new Point(10, 10);

                                ContextMenuStrip actionMenu = new ContextMenuStrip();
                                ToolStripMenuItem ekleItem = new ToolStripMenuItem("Ekle");

                                actionMenu.Items.Add(ekleItem);

                                ekleItem.Click += EkleItem_Click;

                                void EkleItem_Click(object clickedsender, EventArgs clickedEventArgs)
                                {
                                    Form buttonForm = new Form();
                                    buttonForm.Text = "Gönder";
                                    MemoryStream ms2 = new MemoryStream();
                                    Properties.Resources.chattick.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                                    ms2.Seek(0, SeekOrigin.Begin);
                                    Bitmap bitmap2 = new Bitmap(ms2);
                                    Icon chatIcon = Icon.FromHandle(bitmap2.GetHicon());
                                    buttonForm.Icon = chatIcon;
                                    Button fotoEkleButton = new Button();
                                    fotoEkleButton.Image = Properties.Resources.fotoIcon;
                                    fotoEkleButton.Size = new Size(40, 40);
                                    fotoEkleButton.Location = new Point(10, 10);
                                    buttonForm.Controls.Add(fotoEkleButton);

                                    OpenFileDialog openFileDialog2 = new OpenFileDialog();
                                    openFileDialog2.Title = "Resim Seç";
                                    openFileDialog2.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                                    openFileDialog2.Multiselect = false;

                                    fotoEkleButton.Click += (btnSender, clickArgs) =>
                                    {
                                        if (openFileDialog2.ShowDialog() == DialogResult.OK)
                                        {
                                            string selectedFile = openFileDialog2.FileName;

                                            PictureBox pictureBox = new PictureBox();
                                            pictureBox.ImageLocation = selectedFile;
                                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                            flowLayout.Controls.Add(pictureBox);

                                        }
                                    };


                                    Button videoEkleButton = new Button();
                                    videoEkleButton.Image = Properties.Resources.videoIcon;
                                    videoEkleButton.Size = new Size(40, 40);
                                    videoEkleButton.Location = new Point(60, 10);
                                    buttonForm.Controls.Add(videoEkleButton);

                                    OpenFileDialog openFileDialog3 = new OpenFileDialog();
                                    openFileDialog3.Title = "Video Seç";
                                    openFileDialog3.Filter = "Video Dosyaları (*.mp4; *.avi)|*.mp4; *.avi";
                                    openFileDialog3.Multiselect = false;

                                    videoEkleButton.Click += (videoSender, videoEventArgs) =>
                                    {
                                        if (openFileDialog3.ShowDialog() == DialogResult.OK)
                                        {
                                            string selectedFile = openFileDialog3.FileName;

                                        }
                                    };


                                    // Button sesEkleButton = new Button();
                                    // sesEkleButton.Image = Properties.Resources.sesIcon;
                                    // sesEkleButton.Size = new Size(40, 40);
                                    // sesEkleButton.Location = new Point(110, 10);
                                    // buttonForm.Controls.Add(sesEkleButton);

                                    // OpenFileDialog openFileDialog4 = new OpenFileDialog();
                                    // openFileDialog4.Title = "Ses Kaydet";
                                    // openFileDialog4.Filter = "Ses Dosyaları (*.mp3; *.wav)|*.mp3; *.wav";

                                    //MediaPlayer
                                    // sesEkleButton.Click += (sesSender, sesEventArgs) =>
                                    // {
                                    //     if (openFileDialog4.ShowDialog() == DialogResult.OK)
                                    //     {
                                    //         string selectedFile = openFileDialog4.FileName;

                                    //     }
                                    // };
                                    Button dosyaEkleButton = new Button();
                                    dosyaEkleButton.Image = Properties.Resources.Document;
                                    dosyaEkleButton.Size = new Size(40, 40);
                                    dosyaEkleButton.Location = new Point(110, 10);
                                    buttonForm.Controls.Add(dosyaEkleButton);

                                    OpenFileDialog dosyaIletisimKutusu = new OpenFileDialog();
                                    dosyaIletisimKutusu.Title = "Dosya Seç";
                                    dosyaIletisimKutusu.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Word Dosyaları (*.docx)|*.docx|Excel Dosyaları (*.xlsx)|*.xlsx|PowerPoint Dosyaları (*.ppsx)|*.ppsx";

                                    dosyaEkleButton.Click += (dosyasender, dosyaEventargs) =>
                                    {
                                        if (dosyaIletisimKutusu.ShowDialog() == DialogResult.OK)
                                        {
                                            string secilenDosyaYolu = dosyaIletisimKutusu.FileName;

                                        }
                                    };

                                    buttonForm.StartPosition = FormStartPosition.CenterParent;
                                    buttonForm.ShowDialog();
                                }
                                panel1.Controls.Add(actionButton);
                                actionButton.ContextMenuStrip = actionMenu;
                                DevExpress.XtraEditors.MemoEdit memoEdit = new DevExpress.XtraEditors.MemoEdit();
                                memoEdit.Dock = DockStyle.Bottom;
                                memoEdit.Size = new Size(yeniChatForm.ClientSize.Width, 100);
                                memoEdit.Properties.ScrollBars = ScrollBars.None;




                                Button gonderButton = new Button();
                                gonderButton.Text = "Gönder";
                                gonderButton.Dock = DockStyle.Bottom;
                                gonderButton.FlatStyle = FlatStyle.Flat;
                                gonderButton.BackColor = Color.SteelBlue;
                                gonderButton.ForeColor = Color.White;
                                gonderButton.Font = new Font("Arial", 10, FontStyle.Bold);
                                gonderButton.Margin = new Padding(5);
                                yeniChatForm.Load += (esndr, eargs) =>
                                {
                                    string gonderenKullanici = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                                    string mesaj = memoEdit.Text;
                                    string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";

                                    string kullaniciTabloAdi1 = "Mesajlar_" + arkadasAdi;
                                    string kullaniciTabloAdi2 = "Mesajlar_" + kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                                    string query = $@"
                   SELECT MesajMetni, GonderenKullanici, Tarih 
                   FROM {kullaniciTabloAdi1}
                   WHERE GonderenKullanici = '{kullanıcıbil.KullaniciBilgileri.GonderenKullanici}' AND AliciKullanici = '{arkadasAdi}'
                   UNION ALL
                   SELECT MesajMetni, GonderenKullanici, Tarih 
                   FROM {kullaniciTabloAdi2}
                   WHERE GonderenKullanici = '{arkadasAdi}' AND AliciKullanici = '{kullanıcıbil.KullaniciBilgileri.GonderenKullanici}'
                   ORDER BY Tarih";

                                    List<(string GonderenKullanici, DateTime Tarih, string MesajMetni)> tumMesajlar = new List<(string, DateTime, string)>();

                                    using (SqlConnection connection = new SqlConnection(connectionstring))
                                    {
                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            connection.Open();
                                            SqlDataReader reader = command.ExecuteReader();

                                            while (reader.Read())
                                            {
                                                string mesajMetni = reader["MesajMetni"].ToString();
                                                string gonderenKullanici3 = reader["GonderenKullanici"].ToString();
                                                DateTime tarih = Convert.ToDateTime(reader["Tarih"]);

                                                tumMesajlar.Add((gonderenKullanici3, tarih, mesajMetni));
                                            }

                                            reader.Close();
                                        }
                                    }


                                    tumMesajlar = tumMesajlar.OrderBy(m => m.Tarih).ToList();

                                    foreach (var mesaj3 in tumMesajlar)
                                    {
                                        Label mesajLabel = new Label();
                                        mesajLabel.Text = $"{mesaj3.GonderenKullanici} - {mesaj3.Tarih}: {mesaj3.MesajMetni}";
                                        mesajLabel.Font = new Font("Times New Roman", 10);
                                        mesajLabel.AutoSize = true;

                                        if (mesaj3.GonderenKullanici == kullanıcıbil.KullaniciBilgileri.GonderenKullanici)
                                        {
                                            mesajLabel.TextAlign = ContentAlignment.MiddleRight;
                                            mesajLabel.ForeColor = Color.Black;
                                        }
                                        else
                                        {
                                            mesajLabel.TextAlign = ContentAlignment.MiddleLeft;
                                            mesajLabel.ForeColor = Color.DarkGray;
                                        }

                                        flowLayout.Controls.Add(mesajLabel);

                                    }

                                };

                                gonderButton.Click += (sndr, args) =>
                                {
                                    string gonderenKullanici = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                                    string mesaj = memoEdit.Text;



                                    Label yeniMesajLabel = new Label();
                                    yeniMesajLabel.Text = $"{kullanıcıbil.KullaniciBilgileri.GonderenKullanici} - {DateTime.Now.ToString()}: {mesaj}";
                                    yeniMesajLabel.AutoSize = true;
                                    yeniMesajLabel.Font = new Font("Times New Roman", 10);
                                    yeniMesajLabel.TextAlign = ContentAlignment.MiddleRight;
                                    flowLayout.Controls.Add(yeniMesajLabel);



                                    string kullaniciTabloAdi2 = "Mesajlar_" + arkadasAdi;
                                    string query = $"INSERT INTO {kullaniciTabloAdi2} (MesajMetni, GonderenKullanici,AliciKullanici, Tarih) VALUES (@MesajMetni, @GonderenKullanici,@AliciKullanici, GETDATE())";

                                    using (SqlConnection connection = new SqlConnection(connectionstring))
                                    {
                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            command.Parameters.AddWithValue("@MesajMetni", mesaj);
                                            command.Parameters.AddWithValue("@GonderenKullanici", gonderenKullanici);
                                            command.Parameters.AddWithValue("@AliciKullanici", arkadasAdi);

                                            connection.Open();
                                            command.ExecuteNonQuery();
                                        }
                                    }


                                };
                                

                                yeniChatForm.Controls.Add(flowLayout);
                                yeniChatForm.Controls.Add(flowLayout);
                                yeniChatForm.Controls.Add(topPanel);
                                yeniChatForm.Controls.Add(panel1);
                                yeniChatForm.Controls.Add(memoEdit);
                                yeniChatForm.Controls.Add(gonderButton);
                                yeniChatForm.Padding = new Padding(10);
                                yeniChatForm.BackColor = Color.White;

                                yeniChatForm.MdiParent = this;
                                yeniChatForm.Show();
                                chatForms[arkadasAdi] = yeniChatForm;
                              
                                
                            };

                            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { element });
                           

                        }
                    }




                }
            }
        }



        public void EklemeYap(string secilenKisi)
        {



            var accordionElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionElement.Text = secilenKisi;
            accordionElement.Style = ElementStyle.Item;
            accordionElement.Appearance.Default.BackColor = Color.DimGray;
            accordionElement.Appearance.Default.BackColor2 = Color.DimGray;
            accordionElement.Appearance.Default.BorderColor = Color.White;
            accordionElement.Appearance.Default.ForeColor = Color.White;




            accordionElement.Click += (sender, e) =>
            {
                Form yeniChatForm = new Form();
                yeniChatForm.Text = $"ChatTick - {secilenKisi}";
                yeniChatForm.Size = new Size(400, 300);

                string kullaniciTabloAdi = "Mesajlar_" + secilenKisi;

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string checkTableQuery = $"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{kullaniciTabloAdi}') BEGIN " +
                        $"CREATE TABLE {kullaniciTabloAdi} (MesajID INT PRIMARY KEY IDENTITY, MesajMetni NVARCHAR(MAX), GonderenKullanici NVARCHAR(100), AliciKullanici NVARCHAR(100), Tarih DATETIME) END";

                    using (SqlCommand command = new SqlCommand(checkTableQuery, connection))
                    {
                        try
                        {
                            command.ExecuteNonQuery();

                        }
                        catch
                        {

                        }
                    }
                }



                var topPanel = new TableLayoutPanel();
                topPanel.ColumnCount = 2;
                topPanel.RowCount = 2;
                topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                topPanel.Dock = DockStyle.Top;

                byte[] resimBinary = null;


                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string query = "SELECT KULPROFIL FROM KULKARTT WHERE KULADI = @KULADI";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KULADI", secilenKisi);

                        connection.Open();
                        resimBinary = command.ExecuteScalar() as byte[];
                    }
                }


                if (resimBinary != null)
                {
                    using (MemoryStream stream = new MemoryStream(resimBinary))
                    {
                        Image resim = Image.FromStream(stream);
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = resim;

                        topPanel.Controls.Add(pictureBox, 0, 0);
                    }
                }

                var nameLabel = new Label();
                nameLabel.Text = secilenKisi;
                nameLabel.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                nameLabel.Dock = DockStyle.Top;
                nameLabel.AutoSize = true;

                var lastSeenLabel = new Label();
                lastSeenLabel.Font = new Font("Times New Roman", 10);
                lastSeenLabel.Dock = DockStyle.Top;
                lastSeenLabel.AutoSize = true;
                topPanel.Controls.Add(nameLabel, 1, 0);
                topPanel.Controls.Add(lastSeenLabel, 1, 1);
                DateTime sonGorulmeZamani;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        string query = "SELECT CEVRIMICI, SONGORULME FROM KULKARTT WHERE KULADI = @KULADI";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KULADI", secilenKisi);

                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                int cevrimiciDurum = 0;
                                string cevrimiciValue = reader.GetString(0);

                                if (int.TryParse(cevrimiciValue, out cevrimiciDurum))
                                {
                                    if (cevrimiciDurum == 1)
                                    {
                                        lastSeenLabel.Text = "Çevrimiçi";
                                    }
                                    else if (!reader.IsDBNull(1) && DateTime.TryParse(reader["SONGORULME"].ToString(), out sonGorulmeZamani))
                                    {
                                        lastSeenLabel.Text = "Son Görülme: " + sonGorulmeZamani.ToString();
                                    }
                                }
                            }

                            reader.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Kullanıcı kayıtlı olmasına rağmen daha önce programa giriş yapmadığını bilginize sunarız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                flowLayout.FlowDirection = FlowDirection.TopDown;
                flowLayout.Dock = DockStyle.Top;
                flowLayout.Height = 500;


                Panel panel1 = new Panel();
                panel1.Dock = DockStyle.Bottom;
                panel1.Height = 40;




                Button actionButton = new Button();
                actionButton.Text = "...";
                actionButton.Size = new Size(30, 30);
                actionButton.Location = new Point(10, 10);

                ContextMenuStrip actionMenu = new ContextMenuStrip();
                ToolStripMenuItem ekleItem = new ToolStripMenuItem("Ekle");

                actionMenu.Items.Add(ekleItem);

                ekleItem.Click += EkleItem_Click;

                void EkleItem_Click(object clickedsender, EventArgs clickedEventArgs)
                {
                    Form buttonForm = new Form();
                    buttonForm.Text = "Gönder";
                    MemoryStream ms2 = new MemoryStream();
                    Properties.Resources.chattick.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                    ms2.Seek(0, SeekOrigin.Begin);
                    Bitmap bitmap2 = new Bitmap(ms2);
                    Icon chatIcon = Icon.FromHandle(bitmap2.GetHicon());
                    buttonForm.Icon = chatIcon;
                    Button fotoEkleButton = new Button();
                    fotoEkleButton.Image = Properties.Resources.fotoIcon;
                    fotoEkleButton.Size = new Size(40, 40);
                    fotoEkleButton.Location = new Point(10, 10);
                    buttonForm.Controls.Add(fotoEkleButton);

                    OpenFileDialog openFileDialog2 = new OpenFileDialog();
                    openFileDialog2.Title = "Resim Seç";
                    openFileDialog2.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                    openFileDialog2.Multiselect = false;

                    fotoEkleButton.Click += (btnSender, clickArgs) =>
                    {
                        if (openFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            string selectedFile = openFileDialog2.FileName;

                            PictureBox pictureBox = new PictureBox();
                            pictureBox.ImageLocation = selectedFile;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            flowLayout.Controls.Add(pictureBox);

                        }
                    };


                    Button videoEkleButton = new Button();
                    videoEkleButton.Image = Properties.Resources.videoIcon;
                    videoEkleButton.Size = new Size(40, 40);
                    videoEkleButton.Location = new Point(60, 10);
                    buttonForm.Controls.Add(videoEkleButton);

                    OpenFileDialog openFileDialog3 = new OpenFileDialog();
                    openFileDialog3.Title = "Video Seç";
                    openFileDialog3.Filter = "Video Dosyaları (*.mp4; *.avi)|*.mp4; *.avi";
                    openFileDialog3.Multiselect = false;

                    videoEkleButton.Click += (videoSender, videoEventArgs) =>
                    {
                        if (openFileDialog3.ShowDialog() == DialogResult.OK)
                        {
                            string selectedFile = openFileDialog3.FileName;

                        }
                    };


                    // Button sesEkleButton = new Button();
                    // sesEkleButton.Image = Properties.Resources.sesIcon;
                    // sesEkleButton.Size = new Size(40, 40);
                    // sesEkleButton.Location = new Point(110, 10);
                    // buttonForm.Controls.Add(sesEkleButton);

                    // OpenFileDialog openFileDialog4 = new OpenFileDialog();
                    // openFileDialog4.Title = "Ses Kaydet";
                    // openFileDialog4.Filter = "Ses Dosyaları (*.mp3; *.wav)|*.mp3; *.wav";

                    //MediaPlayer
                    // sesEkleButton.Click += (sesSender, sesEventArgs) =>
                    // {
                    //     if (openFileDialog4.ShowDialog() == DialogResult.OK)
                    //     {
                    //         string selectedFile = openFileDialog4.FileName;

                    //     }
                    // };
                    Button dosyaEkleButton = new Button();
                    dosyaEkleButton.Image = Properties.Resources.Document;
                    dosyaEkleButton.Size = new Size(40, 40);
                    dosyaEkleButton.Location = new Point(110, 10);
                    buttonForm.Controls.Add(dosyaEkleButton);

                    OpenFileDialog dosyaIletisimKutusu = new OpenFileDialog();
                    dosyaIletisimKutusu.Title = "Dosya Seç";
                    dosyaIletisimKutusu.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Word Dosyaları (*.docx)|*.docx|Excel Dosyaları (*.xlsx)|*.xlsx|PowerPoint Dosyaları (*.ppsx)|*.ppsx";

                    dosyaEkleButton.Click += (dosyasender, dosyaEventargs) =>
                    {
                        if (dosyaIletisimKutusu.ShowDialog() == DialogResult.OK)
                        {
                            string secilenDosyaYolu = dosyaIletisimKutusu.FileName;

                        }
                    };

                    buttonForm.StartPosition = FormStartPosition.CenterParent;
                    buttonForm.ShowDialog();
                }
                panel1.Controls.Add(actionButton);
                actionButton.ContextMenuStrip = actionMenu;
                DevExpress.XtraEditors.MemoEdit memoEdit = new DevExpress.XtraEditors.MemoEdit();
                memoEdit.Dock = DockStyle.Bottom;
                memoEdit.Size = new Size(yeniChatForm.ClientSize.Width, 100);
                memoEdit.Properties.ScrollBars = ScrollBars.None;




                Button gonderButton = new Button();
                gonderButton.Text = "Gönder";
                gonderButton.Dock = DockStyle.Bottom;
                gonderButton.FlatStyle = FlatStyle.Flat;
                gonderButton.BackColor = Color.SteelBlue;
                gonderButton.ForeColor = Color.White;
                gonderButton.Font = new Font("Arial", 10, FontStyle.Bold);
                gonderButton.Margin = new Padding(5);
                yeniChatForm.Load += (esndr, eargs) =>
                {
                    string gonderenKullanici = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                    string mesaj = memoEdit.Text;
                    string connectionstring = @"Data Source=BERK\SQLEXPRESS;Initial Catalog=PROJEVERİ2023;Persist Security Info=True;User ID=berk;Password=87520";

                    string kullaniciTabloAdi1 = "Mesajlar_" + secilenKisi;
                    string kullaniciTabloAdi2 = "Mesajlar_" + kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                    string query = $@"
                   SELECT MesajMetni, GonderenKullanici, Tarih 
                   FROM {kullaniciTabloAdi1}
                   WHERE GonderenKullanici = '{kullanıcıbil.KullaniciBilgileri.GonderenKullanici}' AND AliciKullanici = '{secilenKisi}'
                   UNION ALL
                   SELECT MesajMetni, GonderenKullanici, Tarih 
                   FROM {kullaniciTabloAdi2}
                   WHERE GonderenKullanici = '{secilenKisi}' AND AliciKullanici = '{kullanıcıbil.KullaniciBilgileri.GonderenKullanici}'
                   ORDER BY Tarih";

                    List<(string GonderenKullanici, DateTime Tarih, string MesajMetni)> tumMesajlar = new List<(string, DateTime, string)>();

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string mesajMetni = reader["MesajMetni"].ToString();
                                string gonderenKullanici3 = reader["GonderenKullanici"].ToString();
                                DateTime tarih = Convert.ToDateTime(reader["Tarih"]);

                                tumMesajlar.Add((gonderenKullanici3, tarih, mesajMetni));
                            }

                            reader.Close();
                        }
                    }


                    tumMesajlar = tumMesajlar.OrderBy(m => m.Tarih).ToList();

                    foreach (var mesaj3 in tumMesajlar)
                    {
                        Label mesajLabel = new Label();
                        mesajLabel.Text = $"{mesaj3.GonderenKullanici} - {mesaj3.Tarih}: {mesaj3.MesajMetni}";
                        mesajLabel.Font = new Font("Times New Roman", 10);
                        mesajLabel.AutoSize = true;

                        if (mesaj3.GonderenKullanici == kullanıcıbil.KullaniciBilgileri.GonderenKullanici)
                        {
                            mesajLabel.TextAlign = ContentAlignment.MiddleRight;
                            mesajLabel.ForeColor = Color.Black;
                        }
                        else
                        {
                            mesajLabel.TextAlign = ContentAlignment.MiddleLeft;
                            mesajLabel.ForeColor = Color.DimGray;
                        }

                        flowLayout.Controls.Add(mesajLabel);

                    }

                };

                gonderButton.Click += (sndr, args) =>
                 {
                     string gonderenKullanici = kullanıcıbil.KullaniciBilgileri.GonderenKullanici;
                     string mesaj = memoEdit.Text;



                     Label yeniMesajLabel = new Label();
                     yeniMesajLabel.Text = $"{kullanıcıbil.KullaniciBilgileri.GonderenKullanici} - {DateTime.Now.ToString()}: {mesaj}";
                     yeniMesajLabel.AutoSize = true;
                     yeniMesajLabel.Font = new Font("Times New Roman", 10);
                     yeniMesajLabel.TextAlign = ContentAlignment.MiddleRight;
                     flowLayout.Controls.Add(yeniMesajLabel);



                     string kullaniciTabloAdi2 = "Mesajlar_" + secilenKisi;
                     string query = $"INSERT INTO {kullaniciTabloAdi2} (MesajMetni, GonderenKullanici,AliciKullanici, Tarih) VALUES (@MesajMetni, @GonderenKullanici,@AliciKullanici, GETDATE())";

                     using (SqlConnection connection = new SqlConnection(connectionstring))
                     {
                         using (SqlCommand command = new SqlCommand(query, connection))
                         {
                             command.Parameters.AddWithValue("@MesajMetni", mesaj);
                             command.Parameters.AddWithValue("@GonderenKullanici", gonderenKullanici);
                             command.Parameters.AddWithValue("@AliciKullanici", secilenKisi);

                             connection.Open();
                             command.ExecuteNonQuery();
                         }
                     }


                 };

                yeniChatForm.Controls.Add(flowLayout);
                yeniChatForm.Controls.Add(flowLayout);
                yeniChatForm.Controls.Add(topPanel);
                yeniChatForm.Controls.Add(panel1);
                yeniChatForm.Controls.Add(memoEdit);
                yeniChatForm.Controls.Add(gonderButton);
                yeniChatForm.Padding = new Padding(10);
                yeniChatForm.BackColor = Color.White;

                yeniChatForm.MdiParent = this;
                yeniChatForm.Show();
                chatForms[secilenKisi] = yeniChatForm;
            };

            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionElement });

        }




        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            try
            {
                arkadasekle f = new arkadasekle();
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            try
            {
                ayarlar f = new ayarlar();
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DateTime sonGorulmeZamani = DateTime.Now;
                kullanıcıbil.KullaniciBilgileri.SonGorulmeZamani = sonGorulmeZamani.ToString();
                string query = "UPDATE KULKARTT SET SONGORULME = @SONGORULME,CEVRIMICI = 0 WHERE KULADI = @KULADI";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SONGORULME", sonGorulmeZamani);
                        command.Parameters.AddWithValue("@KULADI", kullanıcıbil.KullaniciBilgileri.GonderenKullanici);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                Application.Exit();
            }
            catch { }
        }

	
	}
}



