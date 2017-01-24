using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserL
{
	public partial class FrmEnter : Form
	{
		public FrmEnter()
		{
			InitializeComponent();
		}

		shard.ClassShard dt = new shard.ClassShard();

		private void btnEnter_Click(object sender, EventArgs e)
		{
			Int32 Shenase = Convert.ToInt32(txtboxShenase.Text);
			Int32 ramz = Convert.ToInt32(txtboxRamz.Text);
			if (ramz!=null)
			{
				FrmUser f = new FrmUser();
				f.Show();
				//	this.Visible = false;
			}
			else
			{
				MessageBox.Show("رمز ورود شما نادرست است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
