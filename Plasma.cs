using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FractalAnim
{
	class PlasmaField
	{
		FastRandom rnd;

		public enum PlasmaType { Plasma, Cloud };

		public int Width { get; set; }
		public int Height { get; set; }
		public double Roughness { get; set; }
		public double[,] Points { get; set; }
		private double FieldSize { get; set; }

		public PlasmaField()
		{
			rnd = new FastRandom((int)DateTime.Now.Ticks);
			Width = 320;
			Height = 240;
			Roughness = 3.0;
		}

		public void GeneratePlasma()
		{
			FieldSize = (double)(Width + Height);

			double[,] points1 = new double[Width, Height];
			points1 = Generate(Width, Height);
			Points = points1;
		}

		//public static Bitmap DrawPlasmaImage(double[,] points, PlasmaType plasmaType)
		//{
		//    Bitmap bitmap = new Bitmap(points.GetLength(1), points.GetLength(0));
		//    Graphics g = Graphics.FromImage(bitmap);

		//    for (int x = 0; x < bitmap.Width; x++)
		//    {
		//        for (int y = 0; y < bitmap.Height; y++)
		//        {
		//            g.FillRectangle(new SolidBrush(Helper.CalculateColor(points[x, y], plasmaType.ToString())), x, y, 1, 1);
		//        }
		//    }
		//    g.Dispose();
		//    return bitmap;
		//}

		private double Displace(double smallSize)
		{
			double Max = smallSize / FieldSize * Roughness;
			return (rnd.NextDouble() - 0.5) * Max;
		}

		private double[,] Generate(int width, int height)
		{
			double c1, c2, c3, c4;
			double[,] points = new double[width, height];

			c1 = rnd.NextDouble();
			c2 = rnd.NextDouble();
			c3 = rnd.NextDouble();
			c4 = rnd.NextDouble();

			DivideGrid(ref points, 0, 0, width, height, c1, c2, c3, c4);

			return points;
		}

		private void DivideGrid(ref double[,] points, double x, double y, double width, double height, double c1, double c2, double c3, double c4)
		{
			double Edge1, Edge2, Edge3, Edge4, Middle;

			double newWidth = Math.Floor(width / 2);
			double newHeight = Math.Floor(height / 2);

			if (width > 1 || height > 1)
			{
				Middle = ((c1 + c2 + c3 + c4) / 4) + Displace(newWidth + newHeight);

				Edge1 = ((c1 + c2) / 2);
				Edge2 = ((c2 + c3) / 2);
				Edge3 = ((c3 + c4) / 2);
				Edge4 = ((c4 + c1) / 2);

				Middle = Helper.Normalize(Middle);
				Edge1 = Helper.Normalize(Edge1);
				Edge2 = Helper.Normalize(Edge2);
				Edge3 = Helper.Normalize(Edge3);
				Edge4 = Helper.Normalize(Edge4);

				DivideGrid(ref points, x, y, newWidth, newHeight, c1, Edge1, Middle, Edge4);
				DivideGrid(ref points, x + newWidth, y, width - newWidth, newHeight, Edge1, c2, Edge2, Middle);
				DivideGrid(ref points, x + newWidth, y + newHeight, width - newWidth, height - newHeight, Middle, Edge2, c3, Edge3);
				DivideGrid(ref points, x, y + newHeight, newWidth, height - newHeight, Edge4, Middle, Edge3, c4);
			}
			else
			{
				double c = (c1 + c2 + c3 + c4) / 4;

				points[(int)(x), (int)(y)] = c;
				if (width == 2)
				{
					points[(int)(x + 1), (int)(y)] = c;
				}
				if (height == 2)
				{
					points[(int)(x), (int)(y + 1)] = c;
				}
				if ((width == 2) && (height == 2))
				{
					points[(int)(x + 1), (int)(y + 1)] = c;
				}
			}
		}
	}
}
