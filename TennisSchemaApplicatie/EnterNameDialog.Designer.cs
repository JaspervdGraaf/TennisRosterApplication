namespace TennisSchemaApplicatie
{
	partial class EnterNameDialog
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
			this.lblEnterName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEnterName
			// 
			this.lblEnterName.AutoSize = true;
			this.lblEnterName.Location = new System.Drawing.Point(13, 13);
			this.lblEnterName.Name = "lblEnterName";
			this.lblEnterName.Size = new System.Drawing.Size(65, 13);
			this.lblEnterName.TabIndex = 0;
			this.lblEnterName.Text = "Vul naam in:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(85, 13);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(187, 20);
			this.txtName.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(196, 40);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Toevoegen";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// EnterNameDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 70);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblEnterName);
			this.Name = "EnterNameDialog";
			this.Text = "Namen invoeren";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnterName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnAdd;
	}
}