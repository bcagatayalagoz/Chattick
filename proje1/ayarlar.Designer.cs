
namespace proje1
{
	partial class ayarlar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement5,
            this.accordionControlElement6});
			this.accordionControl1.Location = new System.Drawing.Point(0, 0);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.Size = new System.Drawing.Size(1025, 613);
			this.accordionControl1.TabIndex = 0;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement1.Text = "Şifreyi Değiştir";
			this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
			// 
			// accordionControlElement2
			// 
			this.accordionControlElement2.Name = "accordionControlElement2";
			this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement2.Text = "Kullanıcı Adını Değiştir";
			this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
			// 
			// accordionControlElement3
			// 
			this.accordionControlElement3.Name = "accordionControlElement3";
			this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement3.Text = "E-Mail Güncelle";
			this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
			// 
			// accordionControlElement4
			// 
			this.accordionControlElement4.Name = "accordionControlElement4";
			this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement4.Text = "Cep Telefonunu Güncelle";
			this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
			// 
			// accordionControlElement5
			// 
			this.accordionControlElement5.Name = "accordionControlElement5";
			this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement5.Text = "Profil Fotoğrafını Güncelle";
			this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
			// 
			// accordionControlElement6
			// 
			this.accordionControlElement6.Name = "accordionControlElement6";
			this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement6.Text = "Gizlilik Ayarları";
			this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
			// 
			// ayarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 613);
			this.Controls.Add(this.accordionControl1);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ayarlar.IconOptions.Image")));
			this.Name = "ayarlar";
			this.Text = "ChatTick - Ayarlar";
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
	}
}