using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
	public partial class ayarlar : DevExpress.XtraEditors.XtraForm
	{
		public ayarlar()
		{
			InitializeComponent();
		}

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{
			try
			{
				csifre f = new csifre();
				this.Hide();
				f.Show();
			}
			catch { }
		}

		private void accordionControlElement2_Click(object sender, EventArgs e)
		{
			try
			{
				ckulad f = new ckulad();
				this.Hide();
				f.Show();
			}
			catch { }
		}

		private void accordionControlElement3_Click(object sender, EventArgs e)
		{
			try
			{
				cmail f = new cmail();
				this.Hide();
				f.Show();
			}
			catch { }
		}

		private void accordionControlElement4_Click(object sender, EventArgs e)
		{
			try
			{
				ccep f = new ccep();
				this.Hide();
				f.Show();
			}
			catch { }
		}

		private void accordionControlElement5_Click(object sender, EventArgs e)
		{
			try
			{
				cprofil f = new cprofil();
				this.Hide();
				f.Show();
			}
			catch { }
		}

		private void accordionControlElement6_Click(object sender, EventArgs e)
		{
			try
			{
				privacysettings f = new privacysettings();
				this.Hide();
				f.Show();
			}
			catch { }
		}
	}
}
