using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FractalAnim
{
	class Fractal
	{
		public double StartReal { get; set; }
		public double StartImag { get; set; }
		public double EndReal { get; set; }
		public double EndImag { get; set; }
		public double MuReal { get; set; }
		public double MuImag { get; set; }
		public double Limit { get; set; }
		public double xStep { get; set; }
		public double yStep { get; set; }
		public int Power { get; set; }

		public int Width { get; set; }
		public int Height { get; set; }
		public Color[,] Points { get; set; }
		private Color[] palColors = new Color[216];

		public Fractal()
		{
			Width = 500;
			Height = 500;

			int l = 0;
			for (int i = 0; i <= 5; i++)
			{
				for (int j = 0; j <= 5; j++)
				{
					for (int k = 0; k <= 5; k++)
					{
						palColors[l] = Color.FromArgb(255, i * 51, j * 51, k * 51);
						l += 1;
					}
				}
			}
		}

		public static double CalculatePower(ref double Real, ref double Imaginary, double muReal, double muImaginary, int Exponent)
		{
			double Real2 = 0.0;
			double Imag2 = 0.0;
			double Real3 = 0.0;
			double Imag3 = 0.0;
			double limit = 0.0;

			try
			{
				switch (Exponent)
				{
					case 2:
						Real2 = Real * Real;
						Imag2 = Imaginary * Imaginary;
						Imaginary = 2.0 * Imaginary * Real + muImaginary;
						Real = Real2 - Imag2 + muReal;
						limit = Real2 + Imag2;
						break;
					case 3:
						Real2 = Real * Real;
						Imag2 = Imaginary * Imaginary;
						Real3 = Real2 * Real;
						Imag3 = Imag2 * Imaginary;
						Real = Real3 - 3.0 * Real * Imag2 + muReal;
						Imaginary = 3.0 * Real2 * Imaginary - Imag3 + muImaginary;
						limit = Real3 + Real2 + Imag3 + Imag2;
						break;
				}

			}
			catch
			{
				throw;
			}

			return limit;
		}

        public void GenerateMandelbrotSet()
        {
            bool inBounds;
            int k;
            int xPixels = Width;
            int yPixels = Height;
            double curImag;
            double curReal;
            Color[,] points1 = new Color[Width, Height];

            xStep = System.Math.Abs(EndReal - StartReal) / xPixels;
            yStep = System.Math.Abs(EndImag - StartImag) / yPixels;

            for (double i = 0; i <= xPixels - 1; i++)
            {
                double muImag = MuImag;
                for (double j = 0; j <= yPixels - 1; j++)
                {
                    k = 0;
                    inBounds = true;
                    curImag = 0;
                    curReal = 0;
                    muImag = StartImag + j * yStep;
                    MuReal = StartReal + i * xStep;
                    while (k < 215 & inBounds == true)
                    {
                        double tempLimit = Fractal.CalculatePower(ref curReal, ref curImag, MuReal, muImag, Power);
                        if (tempLimit > Limit)
                        {
                            inBounds = false;
                        }
                        k = k + 1;
                    }
                    if (inBounds)
                    {
                        points1[(int)i, (int)j] = palColors[0];
                    }
                    else
                    {
                        points1[(int)i, (int)j] = palColors[k];
                    }
                }
            }

            Points = points1;
        }

		public void GenerateJuliaSet(bool drawBiomorph)
		{
			bool inBounds;
			int k;
			int xPixels = Width;
			int yPixels = Height;
			double curImag;
			double curReal;
			Color[,] points1 = new Color[Width, Height];

			xStep = System.Math.Abs(EndReal - StartReal) / xPixels;
			yStep = System.Math.Abs(EndImag - StartImag) / yPixels;

			for (double i = 0; i <= xPixels - 1; i++)
			{
				for (double j = 0; j <= yPixels - 1; j++)
				{
					k = 0;
					inBounds = true;
					curImag = StartImag + j * yStep;
					curReal = StartReal + i * xStep;
					while (k <= 30 & inBounds == true)
					{
						double curLimit = Fractal.CalculatePower(ref curReal, ref curImag, MuReal, MuImag, Power);
						if (curLimit > Limit)
						{
							inBounds = false;
						}
						k = k + 1;
					}
					if (drawBiomorph)
					{
						if (System.Math.Abs(curReal) < 100 | System.Math.Abs(curImag) < 100)
						{
							points1[(int)i, (int)j] = palColors[215];
						}
					}
					else
					{
						points1[(int)i, (int)j] = palColors[k];
					}
				}
			}
			Points = points1;
		}
	}
}
