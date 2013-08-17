using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FractalAnim
{
    public partial class frmFractal : Form
    {
		private double startReal;
		private double startImag;
		private double endReal;
		private double endImag;

		private double newStartReal;
        private double newStartImag;
        private double newEndReal;
        private double newEndImag;
        
		private double oldStartReal;
        private double oldStartImag;
        private double oldEndReal;
        private double oldEndImag;
        
		private double xStep;
        private double yStep;
        private int fromX;
        private int fromY;
		private int xPixels;
		private int yPixels;
        private Color[] palColors = new Color[216];

        private bool isDrag = false;
        private bool clearBox = false;
        private Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        private Point startPoint;

		private Bitmap bufferBitmap;

        //private bool CancelDrawing = false;

        public frmFractal()
        {
            InitializeComponent();
        }

        private void frmFractal_Load(object sender, System.EventArgs e)
        {
            try
            {
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

                cbxPower.SelectedIndex = 0;
                picField.BackColor = palColors[0];
                txtStartReal.Text = "-2";
                txtStartImag.Text = "-2";
                txtEndReal.Text = "2";
                txtEndImag.Text = "2";
                txtmuReal.Text = "0.6";
                txtmuImag.Text = "0.0";
                oldStartReal = double.Parse(txtStartReal.Text);
                oldStartImag = double.Parse(txtStartImag.Text);
                oldEndReal = double.Parse(txtEndReal.Text);
                oldEndImag = double.Parse(txtEndImag.Text);
                picField.ForeColor = Color.FromArgb(255, 255, 255);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            try
            {
                clearBox = false;
                theRectangle = new Rectangle(0, 0, 0, 0);
                picField.Focus();
                if (rbtMandelbrot.Checked)
                {
                    DrawMandelbrotSet(int.Parse(cbxPower.Text));
                }
                else if (rbtJuliaSet.Checked)
                {
                    DrawJuliaSet(int.Parse(cbxPower.Text), false);
                }
                else
                {
                    DrawJuliaSet(int.Parse(cbxPower.Text), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void picField_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                int X = e.X;
                int Y = e.Y;

                txtStartReal.Text = System.Convert.ToString(oldStartReal);
                txtStartImag.Text = System.Convert.ToString(oldStartImag);
                txtEndReal.Text = System.Convert.ToString(oldEndReal);
                txtEndImag.Text = System.Convert.ToString(oldEndImag);
                
				fromX = X;
                fromY = Y;
                
				newStartReal = X;
                newStartImag = Y;
                
				if ((e.Button == System.Windows.Forms.MouseButtons.Left))
                {
                    isDrag = true;
                    if (clearBox)
                    {
                        ControlPaint.DrawReversibleFrame(theRectangle, this.BackColor, FrameStyle.Thick);
                        theRectangle = new Rectangle(0, 0, 0, 0);
                        clearBox = true;
                    }
                }

                Control control = ((Control)(sender));
                startPoint = control.PointToScreen(new Point(e.X, e.Y));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void picField_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if ((isDrag))
                {
                    ControlPaint.DrawReversibleFrame(theRectangle, this.BackColor, FrameStyle.Thick);
                    Control control = ((Control)(sender));
                    Point endPoint = control.PointToScreen(new Point(e.X, e.Y));
                    int width = endPoint.X - startPoint.X;
                    int height = endPoint.Y - startPoint.Y;

					if (Control.ModifierKeys == Keys.Shift)
					{
						width = height;
					}

                    theRectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
                    ControlPaint.DrawReversibleFrame(theRectangle, this.BackColor, FrameStyle.Thick);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void picField_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                int X = e.X;
                int Y = e.Y;
                double temp;
                isDrag = false;
                if (fromX != X & fromY != Y)
                {
                    newEndReal = X;
                    newEndImag = Y;
                    
					if (newStartReal > newEndReal)
                    {
                        temp = newStartReal;
                        newStartReal = newEndReal;
                        newEndReal = temp;
                    }
                    if (newStartImag > newEndImag)
                    {
                        temp = newStartImag;
                        newStartImag = newEndImag;
                        newEndImag = temp;
                    }

                    newStartReal = newStartReal * xStep + double.Parse(txtStartReal.Text);
                    newStartImag = newStartImag * yStep + double.Parse(txtStartImag.Text);
                    newEndReal = newEndReal * xStep + double.Parse(txtStartReal.Text);
                    newEndImag = newEndImag * yStep + double.Parse(txtStartImag.Text);
                    
					oldStartReal = double.Parse(txtStartReal.Text);
                    oldStartImag = double.Parse(txtStartImag.Text);
                    oldEndReal = double.Parse(txtEndReal.Text);
                    oldEndImag = double.Parse(txtEndImag.Text);
                    
					txtStartReal.Text = System.Convert.ToString(newStartReal);
                    txtStartImag.Text = System.Convert.ToString(newStartImag);
                    txtEndReal.Text = System.Convert.ToString(newEndReal);
                    txtEndImag.Text = System.Convert.ToString(newEndImag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectAllText(object sender, System.EventArgs e)
        {
            try
            {
                TextBox myTB = ((TextBox)(sender));
                myTB.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbtMandelbrot_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (rbtMandelbrot.Checked)
                {
                    txtLimit.Text = "4";
                    txtmuImag.Text = "0.00";
                    txtmuReal.Text = "0.00";
                    txtStartReal.Text = "-2.00";
                    txtStartImag.Text = "-2.00";
                    txtEndReal.Text = "2.00";
                    txtEndImag.Text = "2.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbtJuliaSet_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (rbtJuliaSet.Checked)
                {
                    txtLimit.Text = "4";
                    txtmuReal.Text = "0.60";
                    txtmuImag.Text = "0.00";
                    txtStartReal.Text = "-2.00";
                    txtStartImag.Text = "-2.00";
                    txtEndReal.Text = "2.00";
                    txtEndImag.Text = "2.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbtBiomorph_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (rbtBiomorph.Checked)
                {
                    txtLimit.Text = "100";
                    txtmuReal.Text = "0.60";
                    txtmuImag.Text = "0.00";
                    txtStartReal.Text = "-2.00";
                    txtStartImag.Text = "-2.00";
                    txtEndReal.Text = "2.00";
                    txtEndImag.Text = "2.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

		private void btnStart_Click(object sender, EventArgs e)
		{
			txtStartAnimStartReal.Text = txtStartReal.Text;
			txtStartAnimStartImag.Text = txtStartImag.Text;
			txtStartAnimEndReal.Text = txtEndReal.Text;
			txtStartAnimEndImag.Text = txtEndImag.Text;
			txtStartAnimMuReal.Text = txtmuReal.Text;
			txtStartAnimMuImag.Text = txtmuImag.Text;

			picStartAnim.SizeMode = PictureBoxSizeMode.StretchImage;
			picStartAnim.Image = bufferBitmap.Clone() as Bitmap;
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			txtEndAnimStartReal.Text = txtStartReal.Text;
			txtEndAnimStartImag.Text = txtStartImag.Text;
			txtEndAnimEndReal.Text = txtEndReal.Text;
			txtEndAnimEndImag.Text = txtEndImag.Text;
			txtEndAnimMuReal.Text = txtmuReal.Text;
			txtEndAnimMuImag.Text = txtmuImag.Text;

			picEndAnim.SizeMode = PictureBoxSizeMode.StretchImage;
			picEndAnim.Image = picField.Image;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtStartAnimStartReal.Text = "";
			txtStartAnimStartImag.Text = "";
			txtStartAnimEndReal.Text = "";
			txtStartAnimEndImag.Text = "";
			txtStartAnimMuReal.Text = "";
			txtStartAnimMuImag.Text = "";
			txtEndAnimStartReal.Text = "";
			txtEndAnimStartImag.Text = "";
			txtEndAnimEndReal.Text = "";
			txtEndAnimEndImag.Text = "";
			txtEndAnimMuReal.Text = "";
			txtEndAnimMuImag.Text = "";

			picEndAnim.SizeMode = PictureBoxSizeMode.StretchImage;
			picEndAnim.Image = null;

			picStartAnim.SizeMode = PictureBoxSizeMode.StretchImage;
			picStartAnim.Image = null;
		}

		private void btnAnimate_Click(object sender, EventArgs e)
		{
			int frameCount = 320;
			double step = 1.0 / (double)frameCount;

			int width = picField.Image.Width;
			int height = picField.Image.Height;

			double sStartImag = double.Parse(txtStartAnimStartImag.Text);
			double sStartReal = double.Parse(txtStartAnimStartReal.Text);
			double sEndImag = double.Parse(txtStartAnimEndImag.Text);
			double sEndReal = double.Parse(txtStartAnimEndReal.Text);
			double sMuImag = double.Parse(txtStartAnimMuImag.Text);
			double sMuReal = double.Parse(txtStartAnimMuReal.Text);
			double sLimit = double.Parse(txtStartAnimLimit.Text);

			double eStartImag = double.Parse(txtEndAnimStartImag.Text);
			double eStartReal = double.Parse(txtEndAnimStartReal.Text);
			double eEndImag = double.Parse(txtEndAnimEndImag.Text);
			double eEndReal = double.Parse(txtEndAnimEndReal.Text);
			double eMuImag = double.Parse(txtEndAnimMuImag.Text);
			double eMuReal = double.Parse(txtEndAnimMuReal.Text);
			double eLimit = double.Parse(txtEndAnimLimit.Text);

			for (int frames = 0; frames <= frameCount; frames++)
			{
				string fileName = @"Output\img" + frames.ToString("0000") + ".bmp";

				using (Bitmap myBitmap = new Bitmap(picField.Width, picField.Height))
				{
					using (Graphics myGraphics = Graphics.FromImage(myBitmap))
					{
						myGraphics.Clear(palColors[0]);
						btnGo.Text = "Generating...";

						Fractal frac = new Fractal();
						frac.Height = height;
						frac.Width = width;

						frac.StartImag = sStartImag + (eStartImag - sStartImag) * (step * (double)frames);
						frac.StartReal = sStartReal + (eStartReal - sStartReal) * (step * (double)frames);
						frac.EndImag = sEndImag + (eEndImag - sEndImag) * (step * (double)frames);
						frac.EndReal = sEndReal + (eEndReal - sEndReal) * (step * (double)frames); ;
						frac.MuImag = sMuImag + (eMuImag - sMuImag) * (step * (double)frames); ;
						frac.MuReal = sMuReal + (eMuReal - sMuReal) * (step * (double)frames); ;
						frac.Limit = sLimit + (eLimit - sLimit) * (step * (double)frames); ;
						frac.Power = int.Parse(cbxPower.Text);
                        if (rbtMandelbrot.Checked)
                        {
                            frac.GenerateMandelbrotSet();
                        }
                        else
                        {
                            frac.GenerateJuliaSet(!rbtJuliaSet.Checked);
                        }
						for (int i = 0; i < frac.Width; i++)
						{
							for (int j = 0; j < frac.Height; j++)
							{
								myBitmap.SetPixel(i, j, frac.Points[i, j]);
							}
						}
						myBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
					}
				}

				lblStatus.Text = String.Format("Creating frame {0} out of {1}...", frames, frameCount);
				Application.DoEvents();

				if ((frames % 50 == 0 & frames > 0) | (frames == frameCount))
				{
					lblStatus.Text = String.Format("Creating video file...", frames);
					Application.DoEvents();

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

			lblStatus.Text = "Done.";
			btnGo.Text = "Generate";
		}

		private void DrawMandelbrotSet(int power)
		{
            try
            {
                Bitmap myBitmap;
                Graphics myGraphics;
                double temp;
                double limit;
                double curReal;
                double curImag;
                double muReal;
                double muImag;
                int k;

                myBitmap = new Bitmap(picField.Width, picField.Height);
                myGraphics = Graphics.FromImage(myBitmap);
                myGraphics.Clear(palColors[0]);

                Fractal frac = new Fractal();
                frac.Height = 500;
                frac.Width = 500;
                frac.StartImag = double.Parse(txtStartImag.Text);
                frac.StartReal = double.Parse(txtStartReal.Text);
                frac.EndImag = double.Parse(txtEndImag.Text);
                frac.EndReal = double.Parse(txtEndReal.Text);
                frac.MuImag = double.Parse(txtmuImag.Text);
                frac.MuReal = double.Parse(txtmuReal.Text);
                frac.Limit = double.Parse(txtLimit.Text);
                frac.Power = power;

                frac.GenerateMandelbrotSet();
                for (int i = 0; i < frac.Width; i++)
                {
                    for (int j = 0; j < frac.Height; j++)
                    {
                        myBitmap.SetPixel(i, j, frac.Points[i, j]);
                    }
                }

                btnGo.Text = "Generate";
                bufferBitmap = myBitmap.Clone() as Bitmap;
                picField.Image = bufferBitmap.Clone() as Bitmap;

                oldStartReal = double.Parse(txtStartReal.Text);
                oldStartImag = double.Parse(txtStartImag.Text);
                oldEndReal = double.Parse(txtEndReal.Text);
                oldEndImag = double.Parse(txtEndImag.Text);

                xStep = frac.xStep;
                yStep = frac.yStep;

                myBitmap.Dispose();
                myBitmap = null;

                myGraphics.Dispose();
                myGraphics = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}

		private void DrawJuliaSet(int power, bool drawBiomorph)
		{
			try
			{
				Bitmap myBitmap;
				Graphics myGraphics;

				myBitmap = new Bitmap(picField.Width, picField.Height);
				myGraphics = Graphics.FromImage(myBitmap);
				myGraphics.Clear(palColors[0]);
				btnGo.Text = "Generating...";

				Fractal frac = new Fractal();
				frac.Height = 500;
				frac.Width = 500;
				frac.StartImag = double.Parse(txtStartImag.Text);
				frac.StartReal = double.Parse(txtStartReal.Text);
				frac.EndImag = double.Parse(txtEndImag.Text);
				frac.EndReal = double.Parse(txtEndReal.Text);
				frac.MuImag = double.Parse(txtmuImag.Text);
				frac.MuReal = double.Parse(txtmuReal.Text);
				frac.Limit = double.Parse(txtLimit.Text);
				frac.Power = power;

				frac.GenerateJuliaSet(drawBiomorph);
				for (int i = 0; i < frac.Width; i++)
				{
					for (int j = 0; j < frac.Height; j++)
					{
						myBitmap.SetPixel(i, j, frac.Points[i, j]);
					}
				}

				bufferBitmap = myBitmap.Clone() as Bitmap;
				picField.Image = bufferBitmap.Clone() as Bitmap;

				btnGo.Text = "Generate";
				oldStartReal = double.Parse(txtStartReal.Text);
				oldStartImag = double.Parse(txtStartImag.Text);
				oldEndReal = double.Parse(txtEndReal.Text);
				oldEndImag = double.Parse(txtEndImag.Text);

				xStep = frac.xStep;
				yStep = frac.yStep;

				myBitmap.Dispose();
				myBitmap = null;

				myGraphics.Dispose();
				myGraphics = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
    }
}