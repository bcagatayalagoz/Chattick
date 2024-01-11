
namespace proje1
{
	partial class arkadasekle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arkadasekle));
			this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// listBoxControl1
			// 
			this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxControl1.Location = new System.Drawing.Point(0, 0);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new System.Drawing.Size(1053, 657);
			this.listBoxControl1.TabIndex = 0;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.simpleButton2.Location = new System.Drawing.Point(0, 628);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(1053, 29);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Ekle";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
			// 
			// arkadasekle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 657);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.listBoxControl1);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("arkadasekle.IconOptions.Image")));
			this.Name = "arkadasekle";
			this.Text = "ChatTick - Arkadaş Ekle";
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}