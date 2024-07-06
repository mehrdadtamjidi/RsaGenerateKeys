namespace RsaGenerateKeys
{
	partial class frmMain
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
			this.publicKeyTextBox = new System.Windows.Forms.TextBox();
			this.privateKeyTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGenerateKeys = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// publicKeyTextBox
			// 
			this.publicKeyTextBox.Location = new System.Drawing.Point(15, 31);
			this.publicKeyTextBox.Multiline = true;
			this.publicKeyTextBox.Name = "publicKeyTextBox";
			this.publicKeyTextBox.Size = new System.Drawing.Size(773, 295);
			this.publicKeyTextBox.TabIndex = 0;
			// 
			// privateKeyTextBox
			// 
			this.privateKeyTextBox.Location = new System.Drawing.Point(15, 364);
			this.privateKeyTextBox.Multiline = true;
			this.privateKeyTextBox.Name = "privateKeyTextBox";
			this.privateKeyTextBox.Size = new System.Drawing.Size(773, 295);
			this.privateKeyTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 338);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Private Key";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Public Key";
			// 
			// btnGenerateKeys
			// 
			this.btnGenerateKeys.Location = new System.Drawing.Point(356, 670);
			this.btnGenerateKeys.Name = "btnGenerateKeys";
			this.btnGenerateKeys.Size = new System.Drawing.Size(107, 37);
			this.btnGenerateKeys.TabIndex = 4;
			this.btnGenerateKeys.Text = "Generate Keys";
			this.btnGenerateKeys.UseVisualStyleBackColor = true;
			this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 719);
			this.Controls.Add(this.btnGenerateKeys);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.privateKeyTextBox);
			this.Controls.Add(this.publicKeyTextBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RSA Key Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox publicKeyTextBox;
		private System.Windows.Forms.TextBox privateKeyTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGenerateKeys;
	}
}

