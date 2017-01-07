using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisSchemaApplicatie
{
	public partial class NamesScreen : Form
	{
		public List<string> namesList;
		private StartScreen sc;

		public NamesScreen(StartScreen sc)
		{
			this.sc = sc;
			InitializeComponent();
			lblTournamentName.Text = sc.name;
			namesList = new List<string>();

            namesList.Add("Charlene");
            namesList.Add("Jasper");
            namesList.Add("Henkie");
            namesList.Add("Petertje");


            lsbNames.DataSource = namesList;
			if (lsbNames.Items.Count == 0)
			{
				ButtonEnabled(btnRemove, false);
			}
			else
			{
				lsbNames.SelectedIndex = namesList.IndexOf(namesList.First(), 0);
			}
		}

		private void ButtonEnabled(Button button, bool b)
		{
			button.Enabled = b;
		}

		public void RefreshListBox(ListBox lsb)
		{
			lsb.DataSource = null;
			lsb.DataSource = namesList;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			EnterNameDialog end = new EnterNameDialog(this);
			end.Show();
			ButtonEnabled(btnRemove, true);
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int selected = lsbNames.SelectedIndex;

			try
			{
				namesList.RemoveAt(selected);
			}
			catch (Exception ex)
			{
				
			}

			lsbNames.DataSource = null;
			lsbNames.DataSource = namesList;

			if (lsbNames.Items.Count == 0)
			{
				ButtonEnabled(btnRemove, false);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			StartScreen ss = new StartScreen(sc.name, sc.date);
			ss.Show();
			this.Hide();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			RosterScreen rs = new RosterScreen(namesList, sc);
			rs.Show();
			this.Hide();
		}

		private void lsbNames_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lblEnterNames_Click(object sender, EventArgs e)
		{

		}
	}
}
