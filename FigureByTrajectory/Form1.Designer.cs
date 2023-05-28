namespace FigureByTrajectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            trajectorySize = new TrackBar();
            label1 = new Label();
            colorDialogTrajectory = new ColorDialog();
            colorDialogBG = new ColorDialog();
            buttonTrajectoryColor = new Button();
            buttonBGColor = new Button();
            figureSize = new TrackBar();
            label2 = new Label();
            buttonFigureColor = new Button();
            trackBar1 = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            trackBar2 = new TrackBar();
            colorFigure = new ColorDialog();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trajectorySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)figureSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 519);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trajectorySize
            // 
            trajectorySize.LargeChange = 1;
            trajectorySize.Location = new Point(469, 65);
            trajectorySize.Maximum = 450;
            trajectorySize.Minimum = 100;
            trajectorySize.Name = "trajectorySize";
            trajectorySize.Size = new Size(198, 45);
            trajectorySize.TabIndex = 1;
            trajectorySize.TabStop = false;
            trajectorySize.Value = 100;
            trajectorySize.ValueChanged += trajectorySize_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 47);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Размер траектории";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonTrajectoryColor
            // 
            buttonTrajectoryColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTrajectoryColor.Location = new Point(480, 116);
            buttonTrajectoryColor.Name = "buttonTrajectoryColor";
            buttonTrajectoryColor.Size = new Size(143, 22);
            buttonTrajectoryColor.TabIndex = 3;
            buttonTrajectoryColor.Text = "Цвет траектории";
            buttonTrajectoryColor.UseVisualStyleBackColor = true;
            buttonTrajectoryColor.Click += buttonTrajectoryColor_Click;
            // 
            // buttonBGColor
            // 
            buttonBGColor.Location = new Point(480, 12);
            buttonBGColor.Name = "buttonBGColor";
            buttonBGColor.Size = new Size(101, 22);
            buttonBGColor.TabIndex = 4;
            buttonBGColor.Text = "Цвет фона";
            buttonBGColor.UseVisualStyleBackColor = true;
            buttonBGColor.Click += buttonBGColor_Click;
            // 
            // figureSize
            // 
            figureSize.LargeChange = 1;
            figureSize.Location = new Point(469, 168);
            figureSize.Maximum = 200;
            figureSize.Minimum = 10;
            figureSize.Name = "figureSize";
            figureSize.Size = new Size(198, 45);
            figureSize.TabIndex = 5;
            figureSize.TabStop = false;
            figureSize.Value = 10;
            figureSize.ValueChanged += figureSize_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 150);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 6;
            label2.Text = "Размер фигуры";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonFigureColor
            // 
            buttonFigureColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFigureColor.Location = new Point(480, 219);
            buttonFigureColor.Name = "buttonFigureColor";
            buttonFigureColor.Size = new Size(143, 22);
            buttonFigureColor.TabIndex = 7;
            buttonFigureColor.Text = "Цвет фигуры";
            buttonFigureColor.UseVisualStyleBackColor = true;
            buttonFigureColor.Click += buttonFigureColor_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(469, 272);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(198, 45);
            trackBar1.TabIndex = 8;
            trackBar1.TabStop = false;
            trackBar1.Value = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 254);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 9;
            label3.Text = "Скорость фигуры";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 320);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 10;
            label4.Text = "Скорость \"дыхания\"";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 1;
            trackBar2.Location = new Point(469, 338);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(198, 45);
            trackBar2.TabIndex = 11;
            trackBar2.TabStop = false;
            trackBar2.Value = 1;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(538, 484);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 519);
            Controls.Add(buttonStart);
            Controls.Add(trackBar2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(buttonFigureColor);
            Controls.Add(label2);
            Controls.Add(figureSize);
            Controls.Add(buttonBGColor);
            Controls.Add(buttonTrajectoryColor);
            Controls.Add(label1);
            Controls.Add(trajectorySize);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trajectorySize).EndInit();
            ((System.ComponentModel.ISupportInitialize)figureSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trajectorySize;
        private Label label1;
        private ColorDialog colorDialogTrajectory;
        private ColorDialog colorDialogBG;
        private Button buttonTrajectoryColor;
        private Button buttonBGColor;
        private PictureBox pictureBox1;
        private TrackBar figureSize;
        private Label label2;
        private Button buttonFigureColor;
        private TrackBar trackBar1;
        private Label label3;
        private Label label4;
        private TrackBar trackBar2;
        private ColorDialog colorFigure;
        private Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}