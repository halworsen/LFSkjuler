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
			this.optionPanel = new System.Windows.Forms.Panel();
			this.hideRadio = new System.Windows.Forms.RadioButton();
			this.camouflageRadio = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.censorBox)).BeginInit();
			this.optionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// censorBox
			// 
			this.censorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.censorBox.Location = new System.Drawing.Point(0, 40);
			this.censorBox.Name = "censorBox";
			this.censorBox.Size = new System.Drawing.Size(384, 261);
			this.censorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.censorBox.TabIndex = 0;
			this.censorBox.TabStop = false;
			// 
			// curtain
			// 
			this.curtain.BackColor = System.Drawing.Color.Black;
			this.curtain.Location = new System.Drawing.Point(0, 40);
			this.curtain.Name = "curtain";
			this.curtain.Size = new System.Drawing.Size(384, 261);
			this.curtain.TabIndex = 1;
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.White;
			this.optionPanel.Controls.Add(this.hideRadio);
			this.optionPanel.Controls.Add(this.camouflageRadio);
			this.optionPanel.Location = new System.Drawing.Point(0, 0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(384, 40);
			this.optionPanel.TabIndex = 2;
			// 
			// hideRadio
			// 
			this.hideRadio.AutoSize = true;
			this.hideRadio.Location = new System.Drawing.Point(101, 13);
			this.hideRadio.Name = "hideRadio";
			this.hideRadio.Size = new System.Drawing.Size(48, 17);
			this.hideRadio.TabIndex = 1;
			this.hideRadio.TabStop = true;
			this.hideRadio.Text = "Skjul";
			this.hideRadio.UseVisualStyleBackColor = true;
			this.hideRadio.CheckedChanged += new System.EventHandler(this.hideRadio_CheckedChanged);
			// 
			// camouflageRadio
			// 
			this.camouflageRadio.AutoSize = true;
			this.camouflageRadio.Location = new System.Drawing.Point(13, 13);
			this.camouflageRadio.Name = "camouflageRadio";
			this.camouflageRadio.Size = new System.Drawing.Size(66, 17);
			this.camouflageRadio.TabIndex = 0;
			this.camouflageRadio.TabStop = true;
			this.camouflageRadio.Text = "Kamufler";
			this.camouflageRadio.UseVisualStyleBackColor = true;
			this.camouflageRadio.CheckedChanged += new System.EventHandler(this.camouflageRadio_CheckedChanged);
			// 
			// LFSkjulerForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.ClientSize = new System.Drawing.Size(384, 301);
			this.Controls.Add(this.optionPanel);
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
			this.optionPanel.ResumeLayout(false);
			this.optionPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox censorBox;
		private System.Windows.Forms.Panel curtain;
		private System.Windows.Forms.Panel optionPanel;
		private System.Windows.Forms.RadioButton hideRadio;
		private System.Windows.Forms.RadioButton camouflageRadio;
	}
}

