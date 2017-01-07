namespace TennisSchemaApplicatie
{
	partial class StartScreen
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
			this.lblTournamentName = new System.Windows.Forms.Label();
			this.txtTournamentName = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.lblStartTime = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblDuration = new System.Windows.Forms.Label();
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.lblAmountOfFields = new System.Windows.Forms.Label();
			this.txtAmountOfRounds = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTournamentName
			// 
			this.lblTournamentName.AutoSize = true;
			this.lblTournamentName.Location = new System.Drawing.Point(76, 88);
			this.lblTournamentName.Name = "lblTournamentName";
			this.lblTournamentName.Size = new System.Drawing.Size(78, 13);
			this.lblTournamentName.TabIndex = 0;
			this.lblTournamentName.Text = "Toernooinaam:";
			// 
			// txtTournamentName
			// 
			this.txtTournamentName.Location = new System.Drawing.Point(235, 88);
			this.txtTournamentName.Name = "txtTournamentName";
			this.txtTournamentName.Size = new System.Drawing.Size(200, 20);
			this.txtTournamentName.TabIndex = 1;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(79, 145);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(41, 13);
			this.lblDate.TabIndex = 2;
			this.lblDate.Text = "Datum:";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(235, 145);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 3;
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(79, 212);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(50, 13);
			this.lblStartTime.TabIndex = 4;
			this.lblStartTime.Text = "Begintijd:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(235, 212);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 5;
			// 
			// lblDuration
			// 
			this.lblDuration.AutoSize = true;
			this.lblDuration.Location = new System.Drawing.Point(79, 279);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Size = new System.Drawing.Size(72, 13);
			this.lblDuration.TabIndex = 6;
			this.lblDuration.Text = "Tijd per ronde";
			// 
			// txtDuration
			// 
			this.txtDuration.Location = new System.Drawing.Point(235, 279);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(200, 20);
			this.txtDuration.TabIndex = 7;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(235, 373);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(199, 23);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "Volgende";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(79, 373);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(150, 23);
			this.btnQuit.TabIndex = 9;
			this.btnQuit.Text = "Afsluiten";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// lblAmountOfFields
			// 
			this.lblAmountOfFields.AutoSize = true;
			this.lblAmountOfFields.Location = new System.Drawing.Point(79, 330);
			this.lblAmountOfFields.Name = "lblAmountOfFields";
			this.lblAmountOfFields.Size = new System.Drawing.Size(75, 13);
			this.lblAmountOfFields.TabIndex = 10;
			this.lblAmountOfFields.Text = "Aantal velden:";
			// 
			// txtAmountOfRounds
			// 
			this.txtAmountOfRounds.Location = new System.Drawing.Point(235, 330);
			this.txtAmountOfRounds.Name = "txtAmountOfRounds";
			this.txtAmountOfRounds.Size = new System.Drawing.Size(199, 20);
			this.txtAmountOfRounds.TabIndex = 11;
			// 
			// StartScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 458);
			this.Controls.Add(this.txtAmountOfRounds);
			this.Controls.Add(this.lblAmountOfFields);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.lblDuration);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblStartTime);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.txtTournamentName);
			this.Controls.Add(this.lblTournamentName);
			this.Name = "StartScreen";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTournamentName;
		private System.Windows.Forms.TextBox txtTournamentName;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label lblStartTime;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblDuration;
		private System.Windows.Forms.TextBox txtDuration;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Label lblAmountOfFields;
		private System.Windows.Forms.TextBox txtAmountOfRounds;
	}
}

