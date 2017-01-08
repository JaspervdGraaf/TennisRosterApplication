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
			BackColor = Design.COLORLIGHTER;

			btnNext.BackColor = Design.COLORLIGHTEST;
			btnNext.FlatStyle = FlatStyle.Flat;

			btnQuit.BackColor = Design.COLORLIGHTEST;
			btnQuit.FlatStyle = FlatStyle.Flat;

			this.Font = Design.FONTNORMAL;
			lblTitle.Font = Design.FONTTITLE;
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

			if (name == "")
			{
				MessageBox.Show("Voer de toernooinaam in.");
				return;
			}
			try
			{
				amountOfFields = ConvertStringToInt(txtAmountOfRounds.Text);
				NamesScreen ns = new NamesScreen(this);
				this.Hide();
				ns.Show();
			}
			catch(Exception ex) {
				MessageBox.Show("Vul 'Aantal velden' in met een geldige waarde.");
			}


		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lblDuration_Click(object sender, EventArgs e)
		{

		}

		private void StartScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
