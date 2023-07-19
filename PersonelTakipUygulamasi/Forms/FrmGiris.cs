using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamasi.Forms
{
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}

		private string _veriTabani;

		private void rdbtnSqlite_CheckedChanged(object sender, EventArgs e)
		{
			_veriTabani = "SQLite";
		}

		private void rdbtnSqlServer_CheckedChanged(object sender, EventArgs e)
		{
			_veriTabani = "SqlServer";
		}

		FrmAnaMenu _frmAnaMenü;
		private void btnGiris_Click(object sender, EventArgs e)
		{
			if(rdbtnSqlite.Checked == false && rdbtnSqlServer.Checked == false)
			{
				MessageBox.Show("Lütfen Bir Veri Tabanı Seçiniz.");
			}
			else
			{	
				if(_frmAnaMenü == null || _frmAnaMenü.IsDisposed)
				{
					_frmAnaMenü = new FrmAnaMenu(_veriTabani);
					_frmAnaMenü.Show();
				}

			}
		}

		private void btnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();	
		}
	}
}
