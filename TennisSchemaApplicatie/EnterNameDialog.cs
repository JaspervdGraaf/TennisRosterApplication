using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisSchemaApplicatie
{
	public partial class EnterNameDialog : Form
	{
		public string name;
		private NamesScreen ns;

		public EnterNameDialog(NamesScreen ns)
		{
			this.ns = ns;
			InitializeComponent();

			this.BackColor = Design.COLORLIGHTER;
			this.Font = Design.FONTNORMAL;
			btnAdd.BackColor = Design.COLORLIGHTEST;
			btnAdd.FlatStyle = FlatStyle.Flat;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (ns.namesList.Any(x => x.Equals(txtName.Text)))
			{
				MessageBox.Show("Deze naam is al toegevoegd.");
			}
			else
			{
				ns.namesList.Add(txtName.Text);
				ns.RefreshListBox(ns.lsbNames);
				this.Hide();
			}
			
		}
	}
}
