
namespace proje1
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.kuladi = new ns1.BunifuMaterialTextbox();
			this.kulsifre = new ns1.BunifuMaterialTextbox();
			this.girisbuton = new DevExpress.XtraEditors.SimpleButton();
			this.kaydolbuton = new DevExpress.XtraEditors.SimpleButton();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "ribbonPage2";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(1, 0);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
			this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.ZoomPercent = 40D;
			this.pictureEdit1.Size = new System.Drawing.Size(429, 242);
			this.pictureEdit1.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(21, 329);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(73, 16);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Kullanıcı Adı:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(62, 384);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(32, 16);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Şifre:";
			// 
			// kuladi
			// 
			this.kuladi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.kuladi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.kuladi.ForeColor = System.Drawing.Color.White;
			this.kuladi.HintForeColor = System.Drawing.Color.White;
			this.kuladi.HintText = "";
			this.kuladi.isPassword = false;
			this.kuladi.LineFocusedColor = System.Drawing.Color.AliceBlue;
			this.kuladi.LineIdleColor = System.Drawing.Color.White;
			this.kuladi.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
			this.kuladi.LineThickness = 3;
			this.kuladi.Location = new System.Drawing.Point(101, 301);
			this.kuladi.Margin = new System.Windows.Forms.Padding(4);
			this.kuladi.Name = "kuladi";
			this.kuladi.Size = new System.Drawing.Size(302, 44);
			this.kuladi.TabIndex = 3;
			this.kuladi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.kuladi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kuladi_KeyDown);
			// 
			// kulsifre
			// 
			this.kulsifre.BackColor = System.Drawing.Color.Black;
			this.kulsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.kulsifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.kulsifre.ForeColor = System.Drawing.Color.White;
			this.kulsifre.HintForeColor = System.Drawing.Color.White;
			this.kulsifre.HintText = "";
			this.kulsifre.isPassword = true;
			this.kulsifre.LineFocusedColor = System.Drawing.Color.AliceBlue;
			this.kulsifre.LineIdleColor = System.Drawing.Color.White;
			this.kulsifre.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
			this.kulsifre.LineThickness = 3;
			this.kulsifre.Location = new System.Drawing.Point(101, 356);
			this.kulsifre.Margin = new System.Windows.Forms.Padding(4);
			this.kulsifre.Name = "kulsifre";
			this.kulsifre.Size = new System.Drawing.Size(302, 44);
			this.kulsifre.TabIndex = 3;
			this.kulsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.kulsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kulsifre_KeyDown_1);
			// 
			// girisbuton
			// 
			this.girisbuton.Location = new System.Drawing.Point(308, 460);
			this.girisbuton.Name = "girisbuton";
			this.girisbuton.Size = new System.Drawing.Size(95, 37);
			this.girisbuton.TabIndex = 4;
			this.girisbuton.Text = "Giriş Yap";
			this.girisbuton.Click += new System.EventHandler(this.girisbuton_Click);
			// 
			// kaydolbuton
			// 
			this.kaydolbuton.Location = new System.Drawing.Point(207, 460);
			this.kaydolbuton.Name = "kaydolbuton";
			this.kaydolbuton.Size = new System.Drawing.Size(95, 37);
			this.kaydolbuton.TabIndex = 5;
			this.kaydolbuton.Text = "Kaydol";
			this.kaydolbuton.Click += new System.EventHandler(this.kaydolbuton_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// Form1
			// 
			this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Appearance.ForeColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.Appearance.Options.UseForeColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 588);
			this.Controls.Add(this.kaydolbuton);
			this.Controls.Add(this.girisbuton);
			this.Controls.Add(this.kulsifre);
			this.Controls.Add(this.kuladi);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.pictureEdit1);
			this.IconOptions.Image = global::proje1.Properties.Resources.chat;
			this.Name = "Form1";
			this.Text = "ChatTick";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ns1.BunifuMaterialTextbox kuladi;
        private ns1.BunifuMaterialTextbox kulsifre;
        private DevExpress.XtraEditors.SimpleButton girisbuton;
        private DevExpress.XtraEditors.SimpleButton kaydolbuton;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

