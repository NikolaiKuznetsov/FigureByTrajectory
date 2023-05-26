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
            pictureBox1 = new PictureBox();
            trajectorySize = new TrackBar();
            label1 = new Label();
            colorDialogTrajectory = new ColorDialog();
            colorDialogBG = new ColorDialog();
            buttonTrajectoryColor = new Button();
            buttonBGColor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trajectorySize).BeginInit();
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
            trajectorySize.Location = new Point(469, 35);
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
            label1.Location = new Point(469, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 2;
            label1.Text = "Размер траектории";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonTrajectoryColor
            // 
            buttonTrajectoryColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTrajectoryColor.Location = new Point(499, 89);
            buttonTrajectoryColor.Name = "buttonTrajectoryColor";
            buttonTrajectoryColor.Size = new Size(143, 25);
            buttonTrajectoryColor.TabIndex = 3;
            buttonTrajectoryColor.Text = "Цвет траектории";
            buttonTrajectoryColor.UseVisualStyleBackColor = true;
            buttonTrajectoryColor.Click += buttonTrajectoryColor_Click;
            // 
            // buttonBGColor
            // 
            buttonBGColor.Location = new Point(522, 136);
            buttonBGColor.Name = "buttonBGColor";
            buttonBGColor.Size = new Size(101, 25);
            buttonBGColor.TabIndex = 4;
            buttonBGColor.Text = "Цвет фона";
            buttonBGColor.UseVisualStyleBackColor = true;
            buttonBGColor.Click += buttonBGColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 588);
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
    }
}