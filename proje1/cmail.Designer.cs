
namespace proje1
{
	partial class cmail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmail));
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.kulyenimail2 = new DevExpress.XtraEditors.TextEdit();
			this.kulyenimail = new DevExpress.XtraEditors.TextEdit();
			this.kuleskimail = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenimail2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenimail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskimail.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(501, 270);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(94, 29);
			this.simpleButton1.TabIndex = 16;
			this.simpleButton1.Text = "Güncelle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(344, 245);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(120, 16);
			this.labelControl3.TabIndex = 13;
			this.labelControl3.Text = "E-maili tekrar giriniz:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(354, 217);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(110, 16);
			this.labelControl2.TabIndex = 14;
			this.labelControl2.Text = "Yeni e-maili giriniz:";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(338, 189);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(126, 16);
			this.labelControl1.TabIndex = 15;
			this.labelControl1.Text = "Mevcut E-maili giriniz:";
			// 
			// kulyenimail2
			// 
			this.kulyenimail2.Location = new System.Drawing.Point(470, 242);
			this.kulyenimail2.Name = "kulyenimail2";
			this.kulyenimail2.Size = new System.Drawing.Size(125, 22);
			this.kulyenimail2.TabIndex = 10;
			// 
			// kulyenimail
			// 
			this.kulyenimail.Location = new System.Drawing.Point(470, 214);
			this.kulyenimail.Name = "kulyenimail";
			this.kulyenimail.Size = new System.Drawing.Size(125, 22);
			this.kulyenimail.TabIndex = 11;
			// 
			// kuleskimail
			// 
			this.kuleskimail.Location = new System.Drawing.Point(470, 186);
			this.kuleskimail.Name = "kuleskimail";
			this.kuleskimail.Size = new System.Drawing.Size(125, 22);
			this.kuleskimail.TabIndex = 12;
			// 
			// cmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 529);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.kulyenimail2);
			this.Controls.Add(this.kulyenimail);
			this.Controls.Add(this.kuleskimail);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmail.IconOptions.Image")));
			this.Name = "cmail";
			this.Text = "ChatTick - E-Mail Güncelle";
			((System.ComponentModel.ISupportInitialize)(this.kulyenimail2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenimail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskimail.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit kulyenimail2;
		private DevExpress.XtraEditors.TextEdit kulyenimail;
		private DevExpress.XtraEditors.TextEdit kuleskimail;
	}
}