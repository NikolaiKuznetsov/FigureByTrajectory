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
            figureSpeed = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            figureBreathingRate = new TrackBar();
            colorFigure = new ColorDialog();
            timerFigureSpeed = new System.Windows.Forms.Timer(components);
            timerFigureBreathingRate = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trajectorySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)figureSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)figureSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)figureBreathingRate).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 588);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trajectorySize
            // 
            trajectorySize.LargeChange = 1;
            trajectorySize.Location = new Point(469, 74);
            trajectorySize.Maximum = 450;
            trajectorySize.Minimum = 100;
            trajectorySize.Name = "trajectorySize";
            trajectorySize.Size = new Size(198, 48);
            trajectorySize.TabIndex = 1;
            trajectorySize.TabStop = false;
            trajectorySize.Value = 100;
            trajectorySize.ValueChanged += trajectorySize_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 53);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 2;
            label1.Text = "Размер траектории";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonTrajectoryColor
            // 
            buttonTrajectoryColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTrajectoryColor.Location = new Point(480, 131);
            buttonTrajectoryColor.Name = "buttonTrajectoryColor";
            buttonTrajectoryColor.Size = new Size(143, 25);
            buttonTrajectoryColor.TabIndex = 3;
            buttonTrajectoryColor.Text = "Цвет траектории";
            buttonTrajectoryColor.UseVisualStyleBackColor = true;
            buttonTrajectoryColor.Click += buttonTrajectoryColor_Click;
            // 
            // buttonBGColor
            // 
            buttonBGColor.Location = new Point(480, 14);
            buttonBGColor.Name = "buttonBGColor";
            buttonBGColor.Size = new Size(101, 25);
            buttonBGColor.TabIndex = 4;
            buttonBGColor.Text = "Цвет фона";
            buttonBGColor.UseVisualStyleBackColor = true;
            buttonBGColor.Click += buttonBGColor_Click;
            // 
            // figureSize
            // 
            figureSize.LargeChange = 1;
            figureSize.Location = new Point(469, 190);
            figureSize.Maximum = 200;
            figureSize.Minimum = 10;
            figureSize.Name = "figureSize";
            figureSize.Size = new Size(198, 48);
            figureSize.TabIndex = 5;
            figureSize.TabStop = false;
            figureSize.Value = 10;
            figureSize.ValueChanged += figureSize_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 170);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 6;
            label2.Text = "Размер фигуры";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonFigureColor
            // 
            buttonFigureColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFigureColor.Location = new Point(480, 248);
            buttonFigureColor.Name = "buttonFigureColor";
            buttonFigureColor.Size = new Size(143, 25);
            buttonFigureColor.TabIndex = 7;
            buttonFigureColor.Text = "Цвет фигуры";
            buttonFigureColor.UseVisualStyleBackColor = true;
            buttonFigureColor.Click += buttonFigureColor_Click;
            // 
            // figureSpeed
            // 
            figureSpeed.LargeChange = 1;
            figureSpeed.Location = new Point(469, 308);
            figureSpeed.Minimum = 1;
            figureSpeed.Name = "figureSpeed";
            figureSpeed.RightToLeft = RightToLeft.No;
            figureSpeed.Size = new Size(198, 48);
            figureSpeed.TabIndex = 8;
            figureSpeed.Value = 1;
            figureSpeed.ValueChanged += figureSpeed_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 288);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 9;
            label3.Text = "Скорость фигуры";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 363);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 10;
            label4.Text = "Скорость \"дыхания\"";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // figureBreathingRate
            // 
            figureBreathingRate.LargeChange = 1;
            figureBreathingRate.Location = new Point(469, 383);
            figureBreathingRate.Minimum = 1;
            figureBreathingRate.Name = "figureBreathingRate";
            figureBreathingRate.RightToLeft = RightToLeft.No;
            figureBreathingRate.Size = new Size(198, 48);
            figureBreathingRate.TabIndex = 11;
            figureBreathingRate.Value = 1;
            figureBreathingRate.ValueChanged += figureBreathingRate_ValueChanged;
            // 
            // timerFigureSpeed
            // 
            timerFigureSpeed.Enabled = true;
            timerFigureSpeed.Interval = 40;
            timerFigureSpeed.Tick += timerFigureSpeed_Tick;
            // 
            // timerFigureBreathingRate
            // 
            timerFigureBreathingRate.Enabled = true;
            timerFigureBreathingRate.Interval = 40;
            timerFigureBreathingRate.Tick += timerFigureBreathingRate_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 588);
            Controls.Add(figureBreathingRate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(figureSpeed);
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
            ((System.ComponentModel.ISupportInitialize)figureSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)figureBreathingRate).EndInit();
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
        private TrackBar figureSpeed;
        private Label label3;
        private Label label4;
        private TrackBar figureBreathingRate;
        private ColorDialog colorFigure;
        private System.Windows.Forms.Timer timerFigureSpeed;
        private System.Windows.Forms.Timer timerFigureBreathingRate;
    }
}