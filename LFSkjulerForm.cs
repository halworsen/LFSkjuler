using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LFSkjuler
{

	public enum SolutionHideMode
	{
		/// <summary>
		/// Attempt to blend the solution in with the surrounding
		/// </summary>
		Camouflage,
		/// <summary>
		/// Attempt to hide the solution completely
		/// </summary>
		Hide
	}

	// TODO: show the curtainPanel when the form is being dragged, hide it when not. don't draw to the censor picture when the form is being dragged
	public partial class LFSkjulerForm : Form
	{
		// The bitmap we display on the form to cover up solution text
		private Bitmap censoringBitmap;

		// Whether or not we're currently dragging/resizing the window
		private bool dragSizing = false;

		SolutionHideMode censoringMode = SolutionHideMode.Hide;

		public LFSkjulerForm()
		{
			InitializeComponent();

			this.ShowInTaskbar = true;
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.SizeGripStyle = SizeGripStyle.Show;
			this.MinimumSize = new System.Drawing.Size(100, 100);

			this.ResizeBegin += LFSkjulerForm_ResizeBegin;
			this.Resize += LFSkjulerForm_Resize;
			this.ResizeEnd += LFSkjulerForm_ResizeEnd;
			this.Paint += LFSkjulerForm_Paint;

			censoringBitmap = new Bitmap(this.Bounds.Width, this.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			Display.UpdateReadBitmap();
			RepaintSolutionCensoring();
			curtain.Hide();
		}
		private void LFSkjulerForm_ResizeBegin(object sender, EventArgs e)
		{
			dragSizing = true;

			censorBox.Hide();
			Display.UpdateReadBitmap();
			curtain.Show();
		}

		private void LFSkjulerForm_Resize(object sender, EventArgs e)
		{
			curtain.Size = this.Size;
			optionPanel.Size = new Size(this.Size.Width, optionPanel.Size.Height);
		}

		private void LFSkjulerForm_ResizeEnd(object sender, EventArgs e)
		{
			dragSizing = false;
			if (censoringBitmap != null)
				censoringBitmap.Dispose();
			censoringBitmap = new Bitmap(this.Bounds.Width, this.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			
			RepaintSolutionCensoring();
			censorBox.Show();
			curtain.Hide();
		}

		private void LFSkjulerForm_Paint(object sender, PaintEventArgs e)
		{
			if (dragSizing)
				return;

			RepaintSolutionCensoring();
		}

		private void RepaintSolutionCensoring()
		{
			using (Graphics g = Graphics.FromImage(censoringBitmap))
			{
				Rectangle captureRegion = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
				List<System.Drawing.Point> solutionPixels = Display.GetSolutionPixels(
					captureRegion,
					color => {
						bool highSaturation = !(color.GetSaturation() < 0.1);
						bool hueCheck = true;
						bool brightnessCheck = true;

						if (censoringMode == SolutionHideMode.Hide)
						{
							float hue = color.GetHue();
							hueCheck = (hue < 40 || hue > 320);

							float brightness = color.GetBrightness();
							brightnessCheck = brightness > 0.6;
						}

						return highSaturation && hueCheck;
					}
				);

				for (int i = 0; i < solutionPixels.Count; i++)
				{
					Point pixel = solutionPixels[i];
					Point formPoint = censorBox.PointToClient(pixel);
					g.FillRectangle(
						(censoringMode == SolutionHideMode.Camouflage ? Brushes.Black : Brushes.White),
						formPoint.X, formPoint.Y,
						1, 1
					);
				}
			}

			censorBox.Image = censoringBitmap;
		}

		private void camouflageRadio_CheckedChanged(object sender, EventArgs e)
		{
			if (!camouflageRadio.Checked)
				return;

			censoringMode = SolutionHideMode.Camouflage;
			RepaintSolutionCensoring();
		}

		private void hideRadio_CheckedChanged(object sender, EventArgs e)
		{
			if (!hideRadio.Checked)
				return;

			censoringMode = SolutionHideMode.Hide;
			RepaintSolutionCensoring();
		}
	}
}
