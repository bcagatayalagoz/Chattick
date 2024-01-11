
namespace proje1
{
	partial class ckulad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ckulad));
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.kulyeniad2 = new DevExpress.XtraEditors.TextEdit();
			this.kulyeniad = new DevExpress.XtraEditors.TextEdit();
			this.kuleskiad = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.kulyeniad2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyeniad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskiad.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(363, 215);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(94, 29);
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Güncelle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(168, 190);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(158, 16);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Kullanıcı adını tekrar giriniz:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(179, 162);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(147, 16);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Yeni kullanıcı adını giriniz:";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(163, 134);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(163, 16);
			this.labelControl1.TabIndex = 8;
			this.labelControl1.Text = "Mevcut kullanıcı adını giriniz:";
			// 
			// kulyeniad2
			// 
			this.kulyeniad2.Location = new System.Drawing.Point(332, 187);
			this.kulyeniad2.Name = "kulyeniad2";
			this.kulyeniad2.Size = new System.Drawing.Size(125, 22);
			this.kulyeniad2.TabIndex = 3;
			// 
			// kulyeniad
			// 
			this.kulyeniad.Location = new System.Drawing.Point(332, 159);
			this.kulyeniad.Name = "kulyeniad";
			this.kulyeniad.Size = new System.Drawing.Size(125, 22);
			this.kulyeniad.TabIndex = 4;
			// 
			// kuleskiad
			// 
			this.kuleskiad.Location = new System.Drawing.Point(332, 131);
			this.kuleskiad.Name = "kuleskiad";
			this.kuleskiad.Size = new System.Drawing.Size(125, 22);
			this.kuleskiad.TabIndex = 5;
			// 
			// ckulad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 450);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.kulyeniad2);
			this.Controls.Add(this.kulyeniad);
			this.Controls.Add(this.kuleskiad);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ckulad.IconOptions.Image")));
			this.Name = "ckulad";
			this.Text = "ChatTick - Kullanıcı Adı Değiştir";
			((System.ComponentModel.ISupportInitialize)(this.kulyeniad2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyeniad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskiad.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit kulyeniad2;
		private DevExpress.XtraEditors.TextEdit kulyeniad;
		private DevExpress.XtraEditors.TextEdit kuleskiad;
	}
}