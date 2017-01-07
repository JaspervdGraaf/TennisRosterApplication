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
	public partial class StartScreen : Form
	{
		public string name;
		public DateTime date;
		public int amountOfFields = 0;

		public StartScreen(string name, DateTime date)
		{
			InitializeComponent();
			txtTournamentName.Text = name;
			dtpDate.Value = date;
		}

		public StartScreen()
		{
			InitializeComponent();
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private int ConvertStringToInt(string input)
		{
			int output = Convert.ToInt32(input);
			return output;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			name = txtTournamentName.Text;
			date = dtpDate.Value;
			amountOfFields = ConvertStringToInt(txtAmountOfRounds.Text);
			NamesScreen ns = new NamesScreen(this);
			this.Hide();
			ns.Show();
		}
	}
}
