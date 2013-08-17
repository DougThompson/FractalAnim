namespace FractalAnim
{
    partial class frmFractal
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtmuImag = new System.Windows.Forms.TextBox();
            this.txtmuReal = new System.Windows.Forms.TextBox();
            this.lblXmin = new System.Windows.Forms.Label();
            this.lblXmax = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.rbtBiomorph = new System.Windows.Forms.RadioButton();
            this.rbtJuliaSet = new System.Windows.Forms.RadioButton();
            this.rbtMandelbrot = new System.Windows.Forms.RadioButton();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.picField = new System.Windows.Forms.PictureBox();
            this.txtStartReal = new System.Windows.Forms.TextBox();
            this.txtStartImag = new System.Windows.Forms.TextBox();
            this.txtEndReal = new System.Windows.Forms.TextBox();
            this.framOptions = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxPower = new System.Windows.Forms.ComboBox();
            this.txtEndImag = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picStartAnim = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStartAnimLimit = new System.Windows.Forms.TextBox();
            this.txtStartAnimStartReal = new System.Windows.Forms.TextBox();
            this.txtStartAnimStartImag = new System.Windows.Forms.TextBox();
            this.txtStartAnimEndReal = new System.Windows.Forms.TextBox();
            this.txtStartAnimEndImag = new System.Windows.Forms.TextBox();
            this.txtStartAnimMuImag = new System.Windows.Forms.TextBox();
            this.txtStartAnimMuReal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picEndAnim = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEndAnimLimit = new System.Windows.Forms.TextBox();
            this.txtEndAnimStartReal = new System.Windows.Forms.TextBox();
            this.txtEndAnimStartImag = new System.Windows.Forms.TextBox();
            this.txtEndAnimEndReal = new System.Windows.Forms.TextBox();
            this.txtEndAnimEndImag = new System.Windows.Forms.TextBox();
            this.txtEndAnimMuImag = new System.Windows.Forms.TextBox();
            this.txtEndAnimMuReal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picField)).BeginInit();
            this.framOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartAnim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Location = new System.Drawing.Point(234, 94);
            this.btnGo.Name = "btnGo";
            this.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGo.Size = new System.Drawing.Size(117, 25);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Generate";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtmuImag
            // 
            this.txtmuImag.AcceptsReturn = true;
            this.txtmuImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtmuImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmuImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmuImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmuImag.Location = new System.Drawing.Point(151, 58);
            this.txtmuImag.MaxLength = 0;
            this.txtmuImag.Name = "txtmuImag";
            this.txtmuImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmuImag.Size = new System.Drawing.Size(96, 20);
            this.txtmuImag.TabIndex = 5;
            this.txtmuImag.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // txtmuReal
            // 
            this.txtmuReal.AcceptsReturn = true;
            this.txtmuReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtmuReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmuReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmuReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmuReal.Location = new System.Drawing.Point(43, 58);
            this.txtmuReal.MaxLength = 0;
            this.txtmuReal.Name = "txtmuReal";
            this.txtmuReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmuReal.Size = new System.Drawing.Size(96, 20);
            this.txtmuReal.TabIndex = 4;
            this.txtmuReal.Text = "0.6";
            this.txtmuReal.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // lblXmin
            // 
            this.lblXmin.BackColor = System.Drawing.SystemColors.Control;
            this.lblXmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblXmin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblXmin.Location = new System.Drawing.Point(7, 37);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblXmin.Size = new System.Drawing.Size(44, 18);
            this.lblXmin.TabIndex = 14;
            this.lblXmin.Text = "Start:";
            // 
            // lblXmax
            // 
            this.lblXmax.BackColor = System.Drawing.SystemColors.Control;
            this.lblXmax.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblXmax.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXmax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblXmax.Location = new System.Drawing.Point(139, 38);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblXmax.Size = new System.Drawing.Size(9, 13);
            this.lblXmax.TabIndex = 13;
            this.lblXmax.Text = "+";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(256, 37);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "End:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(376, 35);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(9, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "+";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(139, 63);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(9, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "+";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(23, 62);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(17, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "mu:";
            // 
            // rbtBiomorph
            // 
            this.rbtBiomorph.AutoSize = true;
            this.rbtBiomorph.Checked = true;
            this.rbtBiomorph.Location = new System.Drawing.Point(202, 8);
            this.rbtBiomorph.Name = "rbtBiomorph";
            this.rbtBiomorph.Size = new System.Drawing.Size(70, 18);
            this.rbtBiomorph.TabIndex = 19;
            this.rbtBiomorph.TabStop = true;
            this.rbtBiomorph.Text = "Biomorph";
            this.rbtBiomorph.UseVisualStyleBackColor = true;
            this.rbtBiomorph.CheckedChanged += new System.EventHandler(this.rbtBiomorph_CheckedChanged);
            // 
            // rbtJuliaSet
            // 
            this.rbtJuliaSet.AutoSize = true;
            this.rbtJuliaSet.Location = new System.Drawing.Point(107, 8);
            this.rbtJuliaSet.Name = "rbtJuliaSet";
            this.rbtJuliaSet.Size = new System.Drawing.Size(65, 18);
            this.rbtJuliaSet.TabIndex = 18;
            this.rbtJuliaSet.Text = "Julia Set";
            this.rbtJuliaSet.UseVisualStyleBackColor = true;
            this.rbtJuliaSet.CheckedChanged += new System.EventHandler(this.rbtJuliaSet_CheckedChanged);
            // 
            // rbtMandelbrot
            // 
            this.rbtMandelbrot.AutoSize = true;
            this.rbtMandelbrot.Location = new System.Drawing.Point(12, 8);
            this.rbtMandelbrot.Name = "rbtMandelbrot";
            this.rbtMandelbrot.Size = new System.Drawing.Size(78, 18);
            this.rbtMandelbrot.TabIndex = 17;
            this.rbtMandelbrot.Text = "Mandelbrot";
            this.rbtMandelbrot.UseVisualStyleBackColor = true;
            this.rbtMandelbrot.CheckedChanged += new System.EventHandler(this.rbtMandelbrot_CheckedChanged);
            // 
            // txtLimit
            // 
            this.txtLimit.AcceptsReturn = true;
            this.txtLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLimit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLimit.Location = new System.Drawing.Point(281, 58);
            this.txtLimit.MaxLength = 0;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLimit.Size = new System.Drawing.Size(59, 20);
            this.txtLimit.TabIndex = 16;
            this.txtLimit.Text = "100";
            this.txtLimit.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // picField
            // 
            this.picField.BackColor = System.Drawing.SystemColors.Window;
            this.picField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picField.Cursor = System.Windows.Forms.Cursors.Default;
            this.picField.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.picField.Location = new System.Drawing.Point(2, 135);
            this.picField.Name = "picField";
            this.picField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.picField.Size = new System.Drawing.Size(500, 500);
            this.picField.TabIndex = 9;
            this.picField.TabStop = false;
            this.picField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picField_MouseDown);
            this.picField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picField_MouseMove);
            this.picField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picField_MouseUp);
            // 
            // txtStartReal
            // 
            this.txtStartReal.AcceptsReturn = true;
            this.txtStartReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartReal.Location = new System.Drawing.Point(43, 34);
            this.txtStartReal.MaxLength = 0;
            this.txtStartReal.Name = "txtStartReal";
            this.txtStartReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartReal.Size = new System.Drawing.Size(96, 20);
            this.txtStartReal.TabIndex = 0;
            this.txtStartReal.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // txtStartImag
            // 
            this.txtStartImag.AcceptsReturn = true;
            this.txtStartImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartImag.Location = new System.Drawing.Point(151, 34);
            this.txtStartImag.MaxLength = 0;
            this.txtStartImag.Name = "txtStartImag";
            this.txtStartImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartImag.Size = new System.Drawing.Size(96, 20);
            this.txtStartImag.TabIndex = 1;
            this.txtStartImag.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // txtEndReal
            // 
            this.txtEndReal.AcceptsReturn = true;
            this.txtEndReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndReal.Location = new System.Drawing.Point(281, 33);
            this.txtEndReal.MaxLength = 0;
            this.txtEndReal.Name = "txtEndReal";
            this.txtEndReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndReal.Size = new System.Drawing.Size(96, 20);
            this.txtEndReal.TabIndex = 2;
            this.txtEndReal.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // framOptions
            // 
            this.framOptions.BackColor = System.Drawing.SystemColors.Control;
            this.framOptions.Controls.Add(this.btnEnd);
            this.framOptions.Controls.Add(this.btnStart);
            this.framOptions.Controls.Add(this.cbxPower);
            this.framOptions.Controls.Add(this.rbtBiomorph);
            this.framOptions.Controls.Add(this.rbtJuliaSet);
            this.framOptions.Controls.Add(this.rbtMandelbrot);
            this.framOptions.Controls.Add(this.txtLimit);
            this.framOptions.Controls.Add(this.txtStartReal);
            this.framOptions.Controls.Add(this.txtStartImag);
            this.framOptions.Controls.Add(this.txtEndReal);
            this.framOptions.Controls.Add(this.txtEndImag);
            this.framOptions.Controls.Add(this.btnGo);
            this.framOptions.Controls.Add(this.txtmuImag);
            this.framOptions.Controls.Add(this.txtmuReal);
            this.framOptions.Controls.Add(this.lblXmin);
            this.framOptions.Controls.Add(this.lblXmax);
            this.framOptions.Controls.Add(this.Label1);
            this.framOptions.Controls.Add(this.Label2);
            this.framOptions.Controls.Add(this.Label5);
            this.framOptions.Controls.Add(this.Label6);
            this.framOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.framOptions.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.framOptions.Location = new System.Drawing.Point(2, 3);
            this.framOptions.Name = "framOptions";
            this.framOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.framOptions.Size = new System.Drawing.Size(503, 126);
            this.framOptions.TabIndex = 10;
            this.framOptions.Text = "Options";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnd.Location = new System.Drawing.Point(386, 94);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnd.Size = new System.Drawing.Size(96, 25);
            this.btnEnd.TabIndex = 22;
            this.btnEnd.Text = "End >>";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(386, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(96, 25);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start >>";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxPower
            // 
            this.cbxPower.FormattingEnabled = true;
            this.cbxPower.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbxPower.Location = new System.Drawing.Point(429, 7);
            this.cbxPower.Name = "cbxPower";
            this.cbxPower.Size = new System.Drawing.Size(53, 22);
            this.cbxPower.TabIndex = 20;
            // 
            // txtEndImag
            // 
            this.txtEndImag.AcceptsReturn = true;
            this.txtEndImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndImag.Location = new System.Drawing.Point(386, 33);
            this.txtEndImag.MaxLength = 0;
            this.txtEndImag.Name = "txtEndImag";
            this.txtEndImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndImag.Size = new System.Drawing.Size(96, 20);
            this.txtEndImag.TabIndex = 3;
            this.txtEndImag.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picStartAnim);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtStartAnimLimit);
            this.groupBox1.Controls.Add(this.txtStartAnimStartReal);
            this.groupBox1.Controls.Add(this.txtStartAnimStartImag);
            this.groupBox1.Controls.Add(this.txtStartAnimEndReal);
            this.groupBox1.Controls.Add(this.txtStartAnimEndImag);
            this.groupBox1.Controls.Add(this.txtStartAnimMuImag);
            this.groupBox1.Controls.Add(this.txtStartAnimMuReal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(511, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 272);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Animation";
            // 
            // picStartAnim
            // 
            this.picStartAnim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picStartAnim.Location = new System.Drawing.Point(12, 21);
            this.picStartAnim.Name = "picStartAnim";
            this.picStartAnim.Size = new System.Drawing.Size(125, 125);
            this.picStartAnim.TabIndex = 31;
            this.picStartAnim.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(20, 240);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Limit:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartAnimLimit
            // 
            this.txtStartAnimLimit.AcceptsReturn = true;
            this.txtStartAnimLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimLimit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimLimit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimLimit.Location = new System.Drawing.Point(59, 236);
            this.txtStartAnimLimit.MaxLength = 0;
            this.txtStartAnimLimit.Name = "txtStartAnimLimit";
            this.txtStartAnimLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimLimit.Size = new System.Drawing.Size(59, 20);
            this.txtStartAnimLimit.TabIndex = 29;
            this.txtStartAnimLimit.Text = "100";
            // 
            // txtStartAnimStartReal
            // 
            this.txtStartAnimStartReal.AcceptsReturn = true;
            this.txtStartAnimStartReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimStartReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimStartReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimStartReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimStartReal.Location = new System.Drawing.Point(59, 158);
            this.txtStartAnimStartReal.MaxLength = 0;
            this.txtStartAnimStartReal.Name = "txtStartAnimStartReal";
            this.txtStartAnimStartReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimStartReal.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimStartReal.TabIndex = 17;
            // 
            // txtStartAnimStartImag
            // 
            this.txtStartAnimStartImag.AcceptsReturn = true;
            this.txtStartAnimStartImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimStartImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimStartImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimStartImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimStartImag.Location = new System.Drawing.Point(170, 158);
            this.txtStartAnimStartImag.MaxLength = 0;
            this.txtStartAnimStartImag.Name = "txtStartAnimStartImag";
            this.txtStartAnimStartImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimStartImag.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimStartImag.TabIndex = 18;
            // 
            // txtStartAnimEndReal
            // 
            this.txtStartAnimEndReal.AcceptsReturn = true;
            this.txtStartAnimEndReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimEndReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimEndReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimEndReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimEndReal.Location = new System.Drawing.Point(59, 184);
            this.txtStartAnimEndReal.MaxLength = 0;
            this.txtStartAnimEndReal.Name = "txtStartAnimEndReal";
            this.txtStartAnimEndReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimEndReal.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimEndReal.TabIndex = 19;
            // 
            // txtStartAnimEndImag
            // 
            this.txtStartAnimEndImag.AcceptsReturn = true;
            this.txtStartAnimEndImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimEndImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimEndImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimEndImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimEndImag.Location = new System.Drawing.Point(170, 184);
            this.txtStartAnimEndImag.MaxLength = 0;
            this.txtStartAnimEndImag.Name = "txtStartAnimEndImag";
            this.txtStartAnimEndImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimEndImag.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimEndImag.TabIndex = 20;
            // 
            // txtStartAnimMuImag
            // 
            this.txtStartAnimMuImag.AcceptsReturn = true;
            this.txtStartAnimMuImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimMuImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimMuImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimMuImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimMuImag.Location = new System.Drawing.Point(170, 210);
            this.txtStartAnimMuImag.MaxLength = 0;
            this.txtStartAnimMuImag.Name = "txtStartAnimMuImag";
            this.txtStartAnimMuImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimMuImag.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimMuImag.TabIndex = 22;
            // 
            // txtStartAnimMuReal
            // 
            this.txtStartAnimMuReal.AcceptsReturn = true;
            this.txtStartAnimMuReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartAnimMuReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartAnimMuReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAnimMuReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartAnimMuReal.Location = new System.Drawing.Point(59, 210);
            this.txtStartAnimMuReal.MaxLength = 0;
            this.txtStartAnimMuReal.Name = "txtStartAnimMuReal";
            this.txtStartAnimMuReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartAnimMuReal.Size = new System.Drawing.Size(96, 20);
            this.txtStartAnimMuReal.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Start:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(155, 162);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "+";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(20, 186);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "End:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(154, 186);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(155, 214);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(9, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "+";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(20, 214);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "mu:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picEndAnim);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtEndAnimLimit);
            this.groupBox2.Controls.Add(this.txtEndAnimStartReal);
            this.groupBox2.Controls.Add(this.txtEndAnimStartImag);
            this.groupBox2.Controls.Add(this.txtEndAnimEndReal);
            this.groupBox2.Controls.Add(this.txtEndAnimEndImag);
            this.groupBox2.Controls.Add(this.txtEndAnimMuImag);
            this.groupBox2.Controls.Add(this.txtEndAnimMuReal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(511, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 272);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Animation";
            // 
            // picEndAnim
            // 
            this.picEndAnim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picEndAnim.Location = new System.Drawing.Point(12, 19);
            this.picEndAnim.Name = "picEndAnim";
            this.picEndAnim.Size = new System.Drawing.Size(125, 125);
            this.picEndAnim.TabIndex = 32;
            this.picEndAnim.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(20, 240);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Limit:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndAnimLimit
            // 
            this.txtEndAnimLimit.AcceptsReturn = true;
            this.txtEndAnimLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimLimit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimLimit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimLimit.Location = new System.Drawing.Point(59, 236);
            this.txtEndAnimLimit.MaxLength = 0;
            this.txtEndAnimLimit.Name = "txtEndAnimLimit";
            this.txtEndAnimLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimLimit.Size = new System.Drawing.Size(59, 20);
            this.txtEndAnimLimit.TabIndex = 29;
            this.txtEndAnimLimit.Text = "100";
            // 
            // txtEndAnimStartReal
            // 
            this.txtEndAnimStartReal.AcceptsReturn = true;
            this.txtEndAnimStartReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimStartReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimStartReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimStartReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimStartReal.Location = new System.Drawing.Point(59, 158);
            this.txtEndAnimStartReal.MaxLength = 0;
            this.txtEndAnimStartReal.Name = "txtEndAnimStartReal";
            this.txtEndAnimStartReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimStartReal.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimStartReal.TabIndex = 17;
            // 
            // txtEndAnimStartImag
            // 
            this.txtEndAnimStartImag.AcceptsReturn = true;
            this.txtEndAnimStartImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimStartImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimStartImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimStartImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimStartImag.Location = new System.Drawing.Point(170, 158);
            this.txtEndAnimStartImag.MaxLength = 0;
            this.txtEndAnimStartImag.Name = "txtEndAnimStartImag";
            this.txtEndAnimStartImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimStartImag.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimStartImag.TabIndex = 18;
            // 
            // txtEndAnimEndReal
            // 
            this.txtEndAnimEndReal.AcceptsReturn = true;
            this.txtEndAnimEndReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimEndReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimEndReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimEndReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimEndReal.Location = new System.Drawing.Point(59, 184);
            this.txtEndAnimEndReal.MaxLength = 0;
            this.txtEndAnimEndReal.Name = "txtEndAnimEndReal";
            this.txtEndAnimEndReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimEndReal.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimEndReal.TabIndex = 19;
            // 
            // txtEndAnimEndImag
            // 
            this.txtEndAnimEndImag.AcceptsReturn = true;
            this.txtEndAnimEndImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimEndImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimEndImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimEndImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimEndImag.Location = new System.Drawing.Point(170, 184);
            this.txtEndAnimEndImag.MaxLength = 0;
            this.txtEndAnimEndImag.Name = "txtEndAnimEndImag";
            this.txtEndAnimEndImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimEndImag.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimEndImag.TabIndex = 20;
            // 
            // txtEndAnimMuImag
            // 
            this.txtEndAnimMuImag.AcceptsReturn = true;
            this.txtEndAnimMuImag.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimMuImag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimMuImag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimMuImag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimMuImag.Location = new System.Drawing.Point(170, 210);
            this.txtEndAnimMuImag.MaxLength = 0;
            this.txtEndAnimMuImag.Name = "txtEndAnimMuImag";
            this.txtEndAnimMuImag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimMuImag.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimMuImag.TabIndex = 22;
            // 
            // txtEndAnimMuReal
            // 
            this.txtEndAnimMuReal.AcceptsReturn = true;
            this.txtEndAnimMuReal.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndAnimMuReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndAnimMuReal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndAnimMuReal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndAnimMuReal.Location = new System.Drawing.Point(59, 210);
            this.txtEndAnimMuReal.MaxLength = 0;
            this.txtEndAnimMuReal.Name = "txtEndAnimMuReal";
            this.txtEndAnimMuReal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndAnimMuReal.Size = new System.Drawing.Size(96, 20);
            this.txtEndAnimMuReal.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(9, 158);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Start:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(155, 162);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "+";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(20, 186);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "End:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(154, 186);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(9, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "+";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(155, 214);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(9, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "+";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(20, 214);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "mu:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(674, 582);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(117, 25);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnimate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnimate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnimate.Location = new System.Drawing.Point(512, 582);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnimate.Size = new System.Drawing.Size(117, 25);
            this.btnAnimate.TabIndex = 23;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = false;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(508, 617);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(283, 18);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFractal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 641);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picField);
            this.Controls.Add(this.framOptions);
            this.MinimumSize = new System.Drawing.Size(514, 635);
            this.Name = "frmFractal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Generator";
            this.Load += new System.EventHandler(this.frmFractal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picField)).EndInit();
            this.framOptions.ResumeLayout(false);
            this.framOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartAnim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndAnim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.TextBox txtmuImag;
        public System.Windows.Forms.TextBox txtmuReal;
        public System.Windows.Forms.Label lblXmin;
        public System.Windows.Forms.Label lblXmax;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.RadioButton rbtBiomorph;
        internal System.Windows.Forms.RadioButton rbtJuliaSet;
        internal System.Windows.Forms.RadioButton rbtMandelbrot;
        public System.Windows.Forms.TextBox txtLimit;
        public System.Windows.Forms.PictureBox picField;
        public System.Windows.Forms.TextBox txtStartReal;
        public System.Windows.Forms.TextBox txtStartImag;
        public System.Windows.Forms.TextBox txtEndReal;
        public System.Windows.Forms.Panel framOptions;
        public System.Windows.Forms.TextBox txtEndImag;
        private System.Windows.Forms.ComboBox cbxPower;
		public System.Windows.Forms.Button btnStart;
		public System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox txtStartAnimLimit;
		public System.Windows.Forms.TextBox txtStartAnimStartReal;
		public System.Windows.Forms.TextBox txtStartAnimStartImag;
		public System.Windows.Forms.TextBox txtStartAnimEndReal;
		public System.Windows.Forms.TextBox txtStartAnimEndImag;
		public System.Windows.Forms.TextBox txtStartAnimMuImag;
		public System.Windows.Forms.TextBox txtStartAnimMuReal;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.TextBox txtEndAnimLimit;
		public System.Windows.Forms.TextBox txtEndAnimStartReal;
		public System.Windows.Forms.TextBox txtEndAnimStartImag;
		public System.Windows.Forms.TextBox txtEndAnimEndReal;
		public System.Windows.Forms.TextBox txtEndAnimEndImag;
		public System.Windows.Forms.TextBox txtEndAnimMuImag;
		public System.Windows.Forms.TextBox txtEndAnimMuReal;
		public System.Windows.Forms.Label label13;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.Label label15;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label18;
		public System.Windows.Forms.Button btnReset;
		public System.Windows.Forms.Button btnAnimate;
		public System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picStartAnim;
		private System.Windows.Forms.PictureBox picEndAnim;
    }
}

