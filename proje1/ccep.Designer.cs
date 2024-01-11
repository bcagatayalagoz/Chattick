
namespace proje1
{
	partial class ccep
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ccep));
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.kulyenicep2 = new DevExpress.XtraEditors.TextEdit();
			this.kulyenicep = new DevExpress.XtraEditors.TextEdit();
			this.kuleskicep = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenicep2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenicep.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskicep.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(538, 254);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(94, 29);
			this.simpleButton1.TabIndex = 16;
			this.simpleButton1.Text = "Güncelle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(334, 229);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(167, 16);
			this.labelControl3.TabIndex = 13;
			this.labelControl3.Text = "Cep telefonunu tekrar giriniz:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(346, 201);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(155, 16);
			this.labelControl2.TabIndex = 14;
			this.labelControl2.Text = "Yeni cep telefonunu giriniz:";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(330, 173);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(171, 16);
			this.labelControl1.TabIndex = 15;
			this.labelControl1.Text = "Mevcut cep telefonunu giriniz:";
			// 
			// kulyenicep2
			// 
			this.kulyenicep2.Location = new System.Drawing.Point(508, 226);
			this.kulyenicep2.Name = "kulyenicep2";
			this.kulyenicep2.Size = new System.Drawing.Size(125, 22);
			this.kulyenicep2.TabIndex = 10;
			// 
			// kulyenicep
			// 
			this.kulyenicep.Location = new System.Drawing.Point(507, 198);
			this.kulyenicep.Name = "kulyenicep";
			this.kulyenicep.Size = new System.Drawing.Size(125, 22);
			this.kulyenicep.TabIndex = 11;
			// 
			// kuleskicep
			// 
			this.kuleskicep.Location = new System.Drawing.Point(507, 170);
			this.kuleskicep.Name = "kuleskicep";
			this.kuleskicep.Size = new System.Drawing.Size(125, 22);
			this.kuleskicep.TabIndex = 12;
			// 
			// ccep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1038, 573);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.kulyenicep2);
			this.Controls.Add(this.kulyenicep);
			this.Controls.Add(this.kuleskicep);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ccep.IconOptions.Image")));
			this.Name = "ccep";
			this.Text = "ChatTick - Cep Telefonu Güncelle ";
			((System.ComponentModel.ISupportInitialize)(this.kulyenicep2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kulyenicep.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kuleskicep.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit kulyenicep2;
		private DevExpress.XtraEditors.TextEdit kulyenicep;
		private DevExpress.XtraEditors.TextEdit kuleskicep;
	}
}