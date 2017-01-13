using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TennisSchemaApplicatie
{
	public partial class RosterScreen : Form
	{
		private Label lblCourt;
		private TextBox txtCourt;
		private ListBox lsbTeamA;
		private ListBox lsbTeamB;
		private Panel FieldPanel;

		private List<string> members;

		private DragDropEffects dde1;

		public object lb_item = null;
        public StartScreen startScreen;

		public RosterScreen(List<string> members, StartScreen sc)
		{
			//Comment
			InitializeComponent();
			lsbNames.MouseDown += lsbNames_MouseDown;
			this.members = members;
            startScreen = sc;

			this.BackColor = Design.COLORLIGHTER;
			this.Font = Design.FONTSMALL;

			btnPrint.BackColor = Design.COLORLIGHTEST;
			btnPrint.FlatStyle = FlatStyle.Flat;

			btnSaveAsPDF.BackColor = Design.COLORLIGHTEST;
			btnSaveAsPDF.FlatStyle = FlatStyle.Flat;

			this.FieldPanel = new Panel();			
			this.Controls.Add(FieldPanel);
			FieldPanel.AutoScroll = true;
			FieldPanel.Location = new Point(230, 60);
			FieldPanel.Height = this.Height - 100;
			FieldPanel.Width = 700;

			int x = 0;
			int y = 0;

			#region Generate forms for the amount of fields
			for (int i = 1; i <= startScreen.amountOfFields; i++)
			{
				Label lblCourt = new Label();
				TextBox txtCourt = new TextBox();
				this.lsbTeamA = new ListBox();
				this.lsbTeamB = new ListBox();

				// 
				// lblCourt
				// 
				lblCourt.AutoSize = true;
				lblCourt.Location = new System.Drawing.Point(x, y);
				lblCourt.Name = "lblCourt" + i;
				lblCourt.Size = new System.Drawing.Size(31, 13);
				lblCourt.TabIndex = 1;
				lblCourt.Text = "Veld:";
				// 
				// txtCourt
				// 
				txtCourt.Location = new System.Drawing.Point(x + 53, y);
				txtCourt.Name = "txtCourt" + i;
				txtCourt.Size = new System.Drawing.Size(100, 20);
				txtCourt.TabIndex = 2;
				txtCourt.Text = i + "";
				txtCourt.ReadOnly = true;
				// 
				// lsbTeamA
				// 
				lsbTeamA.FormattingEnabled = true;
				lsbTeamA.Location = new System.Drawing.Point(x, y + 29);
				lsbTeamA.Name = "lsbTeamA" + i;
				lsbTeamA.Size = new System.Drawing.Size(153, 43);
				lsbTeamA.TabIndex = 3;
				// 
				// lsbTeamB
				// 
				lsbTeamB.FormattingEnabled = true;
				lsbTeamB.Location = new System.Drawing.Point(x, y + 79);
				lsbTeamB.Name = "lsbTeamB" + i;
				lsbTeamB.Size = new System.Drawing.Size(153, 43);
				lsbTeamB.TabIndex = 4;

                FieldPanel.Controls.Add(lblCourt);
                FieldPanel.Controls.Add(txtCourt);
                FieldPanel.Controls.Add(lsbTeamA);
                FieldPanel.Controls.Add(lsbTeamB);


                x += 175;
				if (x >= 650)
				{
					x = 0;
					y += 150;
				}

				lsbTeamA.AllowDrop = true;
				lsbTeamB.AllowDrop = true;

				lsbTeamA.DragDrop += lsbTeam_DragDrop;
				lsbTeamA.DragOver += lsbTeam_DragOver;

				lsbTeamB.DragDrop += lsbTeam_DragDrop;
				lsbTeamB.DragOver += lsbTeam_DragOver;

			}
			this.Controls.Add(this.lsbNames);

			lsbNames.DataSource = members;
			lsbNames.AllowDrop = true;
			#endregion

	
		}
		

		private void DataBind()
		{
			lsbNames.BeginUpdate();
			lsbNames.DataSource = null;
			lsbNames.DataSource = members;
			lsbNames.EndUpdate();
		}

		private void lsbTeam_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void lsbTeam_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.StringFormat))
			{
				string str = (string)e.Data.GetData(DataFormats.StringFormat);
				//lsbTeamB.Items.Add(str);

				foreach (Control c in FieldPanel.Controls)
				{
					if (c.GetType() == typeof(ListBox))
					{
						if ((this.PointToClient(Cursor.Position).X - 230) >= c.Location.X && (this.PointToClient(Cursor.Position).X - 230) <= c.Location.X + c.Width && (this.PointToClient(Cursor.Position).Y - 60) 
							>= c.Location.Y && (this.PointToClient(Cursor.Position).Y - 60) <= c.Location.Y + c.Height)
						{
							ListBox lb = (ListBox) c;
                            if (lb.Items.Count >= 2)
                            {
                                MessageBox.Show("Er zitten al 2 personen in dit team.");
                            }
                            else
                            {
                                lb.Items.Add(str);
                            }
						}
					}
				}
			}
		}

		private void lsbNames_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (lsbNames.Items.Count == 0)
					return;
				int index = lsbNames.IndexFromPoint(e.X, e.Y);
				string s = lsbNames.Items[index].ToString();
				DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);
				if (dde1 == DragDropEffects.All)
				{
					members.RemoveAt(lsbNames.SelectedIndex);
					DataBind();
				}
			}catch (Exception ex) {

			}
		}

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            Document roster = new Document(iTextSharp.text.PageSize.A4);
            try
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
                PdfWriter writer = PdfWriter.GetInstance(roster, new FileStream(Directory.GetCurrentDirectory() + 
                    @"\Rosters\" + startScreen.name + " - " + startScreen.date.Year + ".pdf", FileMode.Create));
                roster.Open();

                PdfContentByte cb = writer.DirectContent;

                Paragraph title = new Paragraph(startScreen.name + " - " + startScreen.date.Date.ToShortDateString(), FontFactory.GetFont("Arial", 20));

                iTextSharp.text.Rectangle rectTitle = new iTextSharp.text.Rectangle(
                    roster.PageSize.Width * 0.1f,
                    roster.PageSize.Height * .85f,
                    roster.PageSize.Width * 1f,
                    roster.PageSize.Height * 0.9f);

                ColumnText ctTitle = new ColumnText(cb);
                ctTitle.SetSimpleColumn(rectTitle);
                ctTitle.AddElement(title);
                ctTitle.Go();

                PdfPTable matches = new PdfPTable(3);
                matches.TotalWidth = roster.PageSize.Width - 2f * roster.LeftMargin;

                matches.AddCell("Veld");
                matches.AddCell("Team 1");
                matches.AddCell("Team 2");

                matches.HeaderRows = 1;

                for(int i = 1; i <= startScreen.amountOfFields; i++)
                {
                    foreach (Control c in FieldPanel.Controls)
                    {
                        if(c.GetType() == typeof(TextBox) && c.Name == "txtCourt"+i)
                            matches.AddCell(i.ToString());

                        if(c.GetType() == typeof(ListBox) && c.Name == "lsbTeamA"+i)
                        {
                            ListBox lb = (ListBox)c;
                            string players = "";
                            for(int j = 0; j < lb.Items.Count; j++)
                            {
                                if(j == 1)
                                {
                                    players += ", ";
                                }
                                players += lb.Items[j].ToString();
                            }
                            matches.AddCell(players);
                        }
                        if (c.GetType() == typeof(ListBox) && c.Name == "lsbTeamB" + i)
                        {
                            ListBox lb = (ListBox)c;
                            string players = "";
                            for (int j = 0; j < lb.Items.Count; j++)
                            {
                                if (j == 1)
                                {
                                    players += ", ";
                                }
                                players += lb.Items[j].ToString();
                            }
                            matches.AddCell(players);
                        }
                    }
                }

                

                matches.WriteSelectedRows(0, startScreen.amountOfFields+1, roster.LeftMargin, rectTitle.Bottom, cb);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                roster.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

		private void RosterScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
