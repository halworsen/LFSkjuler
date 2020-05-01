using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Forms;

namespace LFSkjuler
{
	static class Display
	{
		// Bitmap for reading the screen
		private static Bitmap screenRead = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format32bppArgb);

		/// <summary>
		/// Gets the screen dimensions
		/// </summary>
		/// <returns>Width and height of the screen</returns>
		public static Vector GetScreenDimensions()
		{
			return new Vector(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
		}

		/// <summary>
		/// Updates the bitmap used for reading the screen
		/// </summary>
		public static void UpdateReadBitmap()
		{
			using (Graphics readGraphic = Graphics.FromImage(screenRead))
			{
				readGraphic.CopyFromScreen(SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Top, 0, 0, screenRead.Size);
			}
		}

		public unsafe static List<System.Drawing.Point> GetSolutionPixels(Rectangle box)
		{
			BitmapData readData = screenRead.LockBits(new Rectangle(0, 0, screenRead.Width, screenRead.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

			List<System.Drawing.Point> pixels = new List<System.Drawing.Point>();

			byte* screenPtr = (byte*)readData.Scan0;
			for (int y = box.Top; y < box.Bottom; y++)
			{
				for (int x = box.Left; x < box.Right; x++)
				{
					// Where the color data is relative to Scan0. One ARGB value consists of 4 bytes (though we only read RGB)
					int ptrOffset = 4 * (x + y * readData.Width);

					Color color = Color.FromArgb(
						(screenPtr + ptrOffset)[2],
						(screenPtr + ptrOffset)[1],
						(screenPtr + ptrOffset)[0]
					);

					if (CheckColorPartOfSolution(color))
						pixels.Add(new System.Drawing.Point(x, y));
				}
			}

			screenRead.UnlockBits(readData);

			return pixels;
		}
		
		/// <summary>
		/// Checks if the given color could be considered part of the solution
		/// </summary>
		/// <returns></returns>
		private static bool CheckColorPartOfSolution(Color color)
		{
			return !(color.GetSaturation() < 0.1);
		}
	}
}
