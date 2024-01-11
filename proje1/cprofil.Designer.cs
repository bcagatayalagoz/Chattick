
namespace proje1
{
	partial class cprofil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cprofil));
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(547, 276);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(94, 29);
			this.simpleButton1.TabIndex = 23;
			this.simpleButton1.Text = "Güncelle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(339, 227);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(171, 16);
			this.labelControl1.TabIndex = 22;
			this.labelControl1.Text = "Yeni Profil Fotoğrafını Seçiniz:";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(519, 220);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(122, 29);
			this.simpleButton2.TabIndex = 24;
			this.simpleButton2.Text = "Profil Fotoğrafı Seç";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.Location = new System.Drawing.Point(339, 12);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.pictureEdit2.Properties.ZoomPercent = 10D;
			this.pictureEdit2.Size = new System.Drawing.Size(302, 186);
			this.pictureEdit2.TabIndex = 25;
			// 
			// cprofil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 561);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.labelControl1);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("cprofil.IconOptions.Image")));
			this.Name = "cprofil";
			this.Text = "ChatTick - Profil Fotoğrafını Güncelle ";
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
	}
}