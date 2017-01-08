namespace TennisSchemaApplicatie
{
	partial class NamesScreen
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
			this.lblEnterNames = new System.Windows.Forms.Label();
			this.lsbNames = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lblTournamentName = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEnterNames
			// 
			this.lblEnterNames.AutoSize = true;
			this.lblEnterNames.Location = new System.Drawing.Point(160, 60);
			this.lblEnterNames.Name = "lblEnterNames";
			this.lblEnterNames.Size = new System.Drawing.Size(85, 13);
			this.lblEnterNames.TabIndex = 0;
			this.lblEnterNames.Text = "Namen invoeren";
			this.lblEnterNames.Click += new System.EventHandler(this.lblEnterNames_Click);
			// 
			// lsbNames
			// 
			this.lsbNames.FormattingEnabled = true;
			this.lsbNames.Location = new System.Drawing.Point(163, 85);
			this.lsbNames.Name = "lsbNames";
			this.lsbNames.Size = new System.Drawing.Size(257, 238);
			this.lsbNames.TabIndex = 1;
			this.lsbNames.SelectedIndexChanged += new System.EventHandler(this.lsbNames_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(19, 85);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(122, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Toevoegen";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(19, 114);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(122, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Verwijderen";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lblTournamentName
			// 
			this.lblTournamentName.AutoSize = true;
			this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.lblTournamentName.Location = new System.Drawing.Point(27, 18);
			this.lblTournamentName.Name = "lblTournamentName";
			this.lblTournamentName.Size = new System.Drawing.Size(0, 37);
			this.lblTournamentName.TabIndex = 4;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(163, 340);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(118, 23);
			this.btnNext.TabIndex = 5;
			this.btnNext.Text = "Volgende";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(19, 340);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(122, 23);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Terug";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// NamesScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 374);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.lblTournamentName);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lsbNames);
			this.Controls.Add(this.lblEnterNames);
			this.Name = "NamesScreen";
			this.Text = "Tennisapplicatie";
			this.Load += new System.EventHandler(this.NamesScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnterNames;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		public System.Windows.Forms.ListBox lsbNames;
		private System.Windows.Forms.Label lblTournamentName;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
	}
}