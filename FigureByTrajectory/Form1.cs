using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureByTrajectory
{
    public partial class Form1 : Form
    {
        Pen trajectoryPen = new Pen(Properties.Settings.Default.trajectoryColor, 1);
        Pen figurePen = new Pen(Properties.Settings.Default.figureColor, 1);
        int trajectoryDiameter = Properties.Settings.Default.trajectoryDiameter;
        int figureRadius = Properties.Settings.Default.figureRadius;
        int xc;
        int yc;
        double speed = 0.0;
        bool breathingRate = Properties.Settings.Default.breathingRate;

        public Form1()
        {
            InitializeComponent();
            xc = pictureBox1.Width / 2;
            yc = pictureBox1.Height / 2;
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Properties.Settings.Default.BGColor;
            trajectorySize.Value = Properties.Settings.Default.trajectoryDiameter;
            figureBreathingRate.Value = Properties.Settings.Default.figureBreathingRate;
            figureSize.Value = Properties.Settings.Default.figureSize;
            figureSpeed.Value = Properties.Settings.Default.figureSpeed;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.figureRadius = figureRadius;
            Properties.Settings.Default.breathingRate = breathingRate;
            Properties.Settings.Default.figureSize = figureSize.Value;
            Properties.Settings.Default.figureSpeed = figureSpeed.Value;
            Properties.Settings.Default.trajectoryDiameter = trajectorySize.Value;
            Properties.Settings.Default.figureBreathingRate = figureBreathingRate.Value;
            Properties.Settings.Default.Save();
        }

        private void buttonBGColor_Click(object sender, EventArgs e)
        {
            colorDialogBG.Color = Properties.Settings.Default.BGColor;
            colorDialogBG.FullOpen = true;
            if (colorDialogBG.ShowDialog() == DialogResult.Cancel)
                return;
            Properties.Settings.Default.BGColor = colorDialogBG.Color;
            pictureBox1.BackColor = colorDialogBG.Color;
        }

        private void buttonTrajectoryColor_Click(object sender, EventArgs e)
        {
            colorDialogTrajectory.Color = Properties.Settings.Default.trajectoryColor;
            colorDialogTrajectory.FullOpen = true;
            if (colorDialogTrajectory.ShowDialog() == DialogResult.Cancel)
                return;
            Properties.Settings.Default.trajectoryColor = colorDialogTrajectory.Color;
            trajectoryPen = new Pen(colorDialogTrajectory.Color, 1);
        }

        private void buttonFigureColor_Click(object sender, EventArgs e)
        {
            colorFigure.Color = Properties.Settings.Default.figureColor;
            colorFigure.FullOpen = true;
            if (colorFigure.ShowDialog() == DialogResult.Cancel)
                return;
            Properties.Settings.Default.figureColor = colorFigure.Color;
            figurePen = new Pen(colorFigure.Color, 1);
        }

        private void trajectorySize_ValueChanged(object sender, EventArgs e)
        {
            trajectoryDiameter = trajectorySize.Value;
        }

        private void timerFigureSpeed_Tick(object sender, EventArgs e)
        {
            if (breathingRate)
            {
                figureRadius += figureSize.Value / figureBreathingRate.Value;
                if (figureRadius >= figureSize.Value * 2)
                    breathingRate = false;
            }
            else
            {
                figureRadius -= figureSize.Value / figureBreathingRate.Value;
                if (figureRadius <= 10)
                    breathingRate = true;
            }

            if (speed > 2 * Math.PI) speed = 0.0;
            speed += (double)figureSpeed.Value / 10;
            Invalidate(true);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(trajectoryPen, xc - trajectoryDiameter / 2, yc - trajectoryDiameter / 2, trajectoryDiameter, trajectoryDiameter);
            e.Graphics.DrawLines(figurePen, DrawFigure.calculatePointsFigure(xc, yc, figureRadius, trajectoryDiameter, speed));
        }
    }
}