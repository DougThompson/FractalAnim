using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using Splicer;
using Splicer.Timeline;
using Splicer.Renderer;
using Splicer.WindowsMedia;
using System.Windows.Forms;

namespace FractalAnim
{
	class Helper
	{

		public static double Normalize(double number)
		{
			if (number < 0)
			{
				number = 0;
			}
			else if (number > 1.0)
			{
				number = 1.0;
			}

			return number;
		}

		public static Color CalculateColor(double cellValue, string plasmaType)
		{
			double Red = 0;
			double Green = 0;
			double Blue = 0;

			if (plasmaType == "Plasma")
			{
				if (cellValue < 0.5)
				{
					Red = cellValue * 2;
				}
				else
				{
					Red = (1.0 - cellValue) * 2;
				}

				if (cellValue >= 0.3 && cellValue < 0.8)
				{
					Green = (cellValue - 0.3) * 2;
				}
				else if (cellValue < 0.3)
				{
					Green = (0.3 - cellValue) * 2;
				}
				else
				{
					Green = (1.3 - cellValue) * 2;
				}

				if (cellValue >= 0.5)
				{
					Blue = (cellValue - 0.5) * 2;
				}
				else
				{
					Blue = (0.5 - cellValue) * 2;
				}
			}
			else if (plasmaType == "Cloud")
			{

				if (cellValue < 0.3)
				{
					Red = cellValue;
				}
				Red = Green = cellValue;

				Blue = 1;
			}
			else
			{
				Red = Green = Blue = cellValue;
			}

			Red = Math.Round(Red * 255, 0);
			Green = Math.Round(Green * 255, 0);
			Blue = Math.Round(Blue * 255, 0);

			return Color.FromArgb((int)Red, (int)Green, (int)Blue);
		}

		public static void createVideo(string outputFile, string tempFileName, int width, int height, bool append)
		{
			if (!append)
				tempFileName = outputFile;

			using (ITimeline timeline = new DefaultTimeline())
			{
				IGroup group = timeline.AddVideoGroup(32, width, height);
				ITrack videoTrack = group.AddTrack();

				foreach (var filename in Directory.GetFiles(@"Output\"))
				{
					videoTrack.AddImage(filename, 0, (1.0 / 48.0));
				}

				ITrack audioTrack = timeline.AddAudioGroup().AddTrack();
				try
				{
					using (AviFileRenderer renderer = new AviFileRenderer(timeline, tempFileName))
					{
						renderer.Render();
					}
				}
				catch (Exception ex)
				{

					throw;
				}
			}

			if (append)
			{
				using (ITimeline timeline = new DefaultTimeline())
				{
					IGroup group = timeline.AddVideoGroup(32, width, height);
					ITrack videoTrack = group.AddTrack();

					var firstVideoClip = group.AddTrack().AddVideo(outputFile);
					var secondVideoClip = group.AddTrack().AddVideo(tempFileName, firstVideoClip.Duration);

					ITrack audioTrack = timeline.AddAudioGroup().AddTrack();
					try
					{
						using (AviFileRenderer renderer = new AviFileRenderer(timeline, "_" + outputFile))
						{
							renderer.Render();
						}

						Application.DoEvents();
						System.Threading.Thread.Sleep(1000);

						File.Delete(outputFile);
						File.Delete(tempFileName);
						File.Move("_" + outputFile, outputFile);
					}
					catch (Exception ex)
					{
						throw;
					}
				}
			}
		}


	}
}
