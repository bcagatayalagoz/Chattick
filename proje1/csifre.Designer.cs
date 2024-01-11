
namespace proje1
{
	partial class csifre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csifre));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.kulyenisifre2 = new DevExpress.XtraEditors.TextEdit();
			this.kulyenisifre = new DevExpress.XtraEditors.TextEdit();
			this.kuleskisifre = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenisifre2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenisifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskisifre.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(211, 127);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(121, 16);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Mevcut şifreyi giriniz:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(227, 155);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(105, 16);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Yeni şifreyi giriniz:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(215, 183);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(117, 16);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Şifreyi tekrar giriniz:";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(369, 208);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(94, 29);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "Güncelle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// kulyenisifre2
			// 
			this.kulyenisifre2.Location = new System.Drawing.Point(338, 180);
			this.kulyenisifre2.Name = "kulyenisifre2";
			this.kulyenisifre2.Size = new System.Drawing.Size(125, 22);
			this.kulyenisifre2.TabIndex = 0;
			this.kulyenisifre2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kulyenisifre2_KeyDown);
			// 
			// kulyenisifre
			// 
			this.kulyenisifre.Location = new System.Drawing.Point(338, 152);
			this.kulyenisifre.Name = "kulyenisifre";
			this.kulyenisifre.Size = new System.Drawing.Size(125, 22);
			this.kulyenisifre.TabIndex = 0;
			this.kulyenisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kulyenisifre_KeyDown);
			// 
			// kuleskisifre
			// 
			this.kuleskisifre.Location = new System.Drawing.Point(338, 124);
			this.kuleskisifre.Name = "kuleskisifre";
			this.kuleskisifre.Size = new System.Drawing.Size(125, 22);
			this.kuleskisifre.TabIndex = 0;
			this.kuleskisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kuleskisifre_KeyDown);
			// 
			// csifre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 450);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.kulyenisifre2);
			this.Controls.Add(this.kulyenisifre);
			this.Controls.Add(this.kuleskisifre);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("csifre.IconOptions.Image")));
			this.Name = "csifre";
			this.Text = "ChatTick - Şifreyi Değiştir";
			this.Load += new System.EventHandler(this.csifre_Load);
			((System.ComponentModel.ISupportInitialize)(this.kulyenisifre2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenisifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskisifre.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit kuleskisifre;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit kulyenisifre;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit kulyenisifre2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}