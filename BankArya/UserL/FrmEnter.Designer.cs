namespace UserL
{
	partial class FrmEnter
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtboxRamz = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtboxShenase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(164, 100);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCancel.Size = new System.Drawing.Size(98, 34);
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(175, 67);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "رمز ورود:";
			// 
			// txtboxRamz
			// 
			this.txtboxRamz.Location = new System.Drawing.Point(22, 64);
			this.txtboxRamz.Name = "txtboxRamz";
			this.txtboxRamz.PasswordChar = '*';
			this.txtboxRamz.Size = new System.Drawing.Size(116, 20);
			this.txtboxRamz.TabIndex = 14;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(40, 100);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEnter.Size = new System.Drawing.Size(98, 34);
			this.btnEnter.TabIndex = 13;
			this.btnEnter.Text = "ورود";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(175, 32);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "شناسه کاربری:";
			// 
			// txtboxShenase
			// 
			this.txtboxShenase.Location = new System.Drawing.Point(22, 29);
			this.txtboxShenase.Name = "txtboxShenase";
			this.txtboxShenase.Size = new System.Drawing.Size(116, 20);
			this.txtboxShenase.TabIndex = 11;
			// 
			// FrmEnter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 157);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtboxRamz);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtboxShenase);
			this.Name = "FrmEnter";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtboxRamz;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtboxShenase;
	}
}

