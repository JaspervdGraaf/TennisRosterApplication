namespace TennisSchemaApplicatie
{
	partial class RosterScreen
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
			this.lsbNames = new System.Windows.Forms.ListBox();
			this.btnSaveAsPDF = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lsbNames
			// 
			this.lsbNames.FormattingEnabled = true;
			this.lsbNames.Location = new System.Drawing.Point(13, 60);
			this.lsbNames.Name = "lsbNames";
			this.lsbNames.Size = new System.Drawing.Size(181, 485);
			this.lsbNames.TabIndex = 0;
			// 
			// btnSaveAsPDF
			// 
			this.btnSaveAsPDF.Location = new System.Drawing.Point(23, 522);
			this.btnSaveAsPDF.Name = "btnSaveAsPDF";
			this.btnSaveAsPDF.Size = new System.Drawing.Size(113, 23);
			this.btnSaveAsPDF.TabIndex = 0;
			this.btnSaveAsPDF.Text = "Opslaan als PDF";
			this.btnSaveAsPDF.UseVisualStyleBackColor = true;
			this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(23, 552);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(113, 23);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// RosterScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 586);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnSaveAsPDF);
			this.Name = "RosterScreen";
			this.Text = "Tennisapplicatie";
			this.Load += new System.EventHandler(this.RosterScreen_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lsbNames;
        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.Button btnPrint;
    }
}