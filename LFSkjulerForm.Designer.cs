namespace LFSkjuler
{
	partial class LFSkjulerForm
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
			this.censorBox = new System.Windows.Forms.PictureBox();
			this.curtain = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.censorBox)).BeginInit();
			this.SuspendLayout();
			// 
			// censorBox
			// 
			this.censorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.censorBox.Location = new System.Drawing.Point(0, 0);
			this.censorBox.Name = "censorBox";
			this.censorBox.Size = new System.Drawing.Size(384, 261);
			this.censorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.censorBox.TabIndex = 0;
			this.censorBox.TabStop = false;
			// 
			// curtain
			// 
			this.curtain.BackColor = System.Drawing.Color.Black;
			this.curtain.Location = new System.Drawing.Point(0, 0);
			this.curtain.Name = "curtain";
			this.curtain.Size = new System.Drawing.Size(384, 261);
			this.curtain.TabIndex = 1;
			// 
			// LFSkjulerForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.curtain);
			this.Controls.Add(this.censorBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LFSkjulerForm";
			this.ShowIcon = false;
			this.Text = "LF-Skjulifiserer";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			((System.ComponentModel.ISupportInitialize)(this.censorBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox censorBox;
		private System.Windows.Forms.Panel curtain;
	}
}

