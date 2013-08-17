using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FractalAnim
{
	public partial class frmPlasma : Form
	{
		static int fieldWidth = 320;
		static int fieldHeight = 240;

		double[,] points2 = new double[fieldWidth, fieldHeight];

		PlasmaField plasma1 = new PlasmaField();
		PlasmaField plasma3 = new PlasmaField();

		public frmPlasma()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DrawPlasmaFields();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			DrawPlasmaFields();
		}

		private void btnAnimate_Click(object sender, EventArgs e)
		{
			int frameCount = 320;
			double step = 1.0 / (double)frameCount;

			int width = pictureBox1.Image.Width;
			int height = pictureBox1.Image.Height;

			for (int frames = 0; frames <= frameCount; frames++)
			{
				for (int x = 0; x < width; x++)
				{
					for (int y = 0; y < height; y++)
					{
						points2[x, y] = plasma1.Points[x, y] + (plasma3.Points[x, y] - plasma1.Points[x, y]) * (step * (double)frames);
					}
				}
				string filename = @"Output\img" + frames.ToString("0000") + ".bmp";
				DrawPlasmaImage(filename, points2, "Plasma", width, height);
				Application.DoEvents();

				if ((frames % 50 == 0 & frames > 0) | (frames == frameCount))
				{
					if (frames == 50)
					{
						Helper.createVideo("Test.avi", null, width, height, false);
					}
					else
					{
						Helper.createVideo("Test.avi", String.Format("Temp{0}.avi", frames), width, height, true);
					}

					Application.DoEvents();
					System.Threading.Thread.Sleep(1000);
					foreach (var img in Directory.GetFiles(@"Output\"))
					{
						File.Delete(img);
					}
				}
			}
		}

		private void DrawPlasmaFields()
		{
			Bitmap bmp1 = new Bitmap(fieldWidth, fieldHeight);
			Bitmap bmp2 = new Bitmap(fieldWidth, fieldHeight);
			Bitmap bmp3 = new Bitmap(fieldWidth, fieldHeight);

			plasma1.Width = fieldWidth;
			plasma1.Height = fieldHeight;
			plasma1.Roughness = 3.0;
			plasma1.GeneratePlasma();

			plasma3.Width = fieldWidth;
			plasma3.Height = fieldHeight;
			plasma3.Roughness = 3.0;
			plasma3.GeneratePlasma();

			for (int x = 0; x < fieldWidth; x++)
			{
				for (int y = 0; y < fieldHeight; y++)
				{
					points2[x, y] = plasma1.Points[x, y] + (plasma3.Points[x, y] - plasma1.Points[x, y]) * (1.0 / 2.0);
				}
			}

			DrawPlasmaImage(pictureBox1, plasma1.Points, "Plasma", fieldWidth, fieldHeight);
			DrawPlasmaImage(pictureBox2, points2, "Plasma", fieldWidth, fieldHeight);
			DrawPlasmaImage(pictureBox3, plasma3.Points, "Plasma", fieldWidth, fieldHeight);
		}

		public void DrawPlasmaImage(PictureBox pictureBox, double[,] points, string plasmaType, int Width, int Height)
		{
			DrawPlasmaImage(pictureBox, null, points, plasmaType, Width, Height);
		}

		public void DrawPlasmaImage(string fileName, double[,] points, string plasmaType, int Width, int Height)
		{
			DrawPlasmaImage(null, fileName, points, plasmaType, Width, Height);
		}

		public void DrawPlasmaImage(PictureBox pictureBox, string fileName, double[,] points, string plasmaType, int iWidth, int iHeight)
		{
			Bitmap bmp = new Bitmap(iWidth, iHeight);
			Graphics g = Graphics.FromImage(bmp);

			for (int x = 0; x < iWidth; x++)
			{
				for (int y = 0; y < iHeight; y++)
				{
					g.FillRectangle(new SolidBrush(Helper.CalculateColor(points[x, y], plasmaType)), x, y, 1, 1);
				}
			}

			if (pictureBox != null)
			{
				pictureBox.Image = new Bitmap(bmp);
			}
			else
			{
				bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
			}
			bmp.Dispose();
			g.Dispose();
		}
	}
}
