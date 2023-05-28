using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureByTrajectory
{
    public partial class Form1 : Form
    {
        Color BGColor = Color.White;
        Color trajectoryColor = Color.Black;
        Color figureColor = Color.Black;
        Graphics graphics;
        DrawTrajectory trajectory;
        DrawFigure figure;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            trajectory = new DrawTrajectory(graphics, trajectoryColor, pictureBox1.Width / 2, pictureBox1.Height / 2, trajectorySize.Value);
            figure = new DrawFigure(graphics, figureColor, pictureBox1.Width / 2, pictureBox1.Height / 2, figureSize.Value, trajectorySize.Value);
            itemsDraw();
        }

        private void itemsDraw()
        {
            graphics.Clear(BGColor);
            trajectory.Draw();
            figure.Draw();
        }

        private void buttonBGColor_Click(object sender, EventArgs e)
        {
            colorDialogBG.Color = BGColor;
            colorDialogBG.FullOpen = true;
            if (colorDialogBG.ShowDialog() == DialogResult.Cancel)
                return;
            BGColor = colorDialogBG.Color;
            itemsDraw();
        }

        private void buttonTrajectoryColor_Click(object sender, EventArgs e)
        {
            colorDialogTrajectory.Color = trajectoryColor;
            colorDialogTrajectory.FullOpen = true;
            if (colorDialogTrajectory.ShowDialog() == DialogResult.Cancel)
                return;
            trajectory.trajectoryColor = trajectoryColor = colorDialogTrajectory.Color;
            itemsDraw();
        }

        private void buttonFigureColor_Click(object sender, EventArgs e)
        {
            colorFigure.Color = trajectoryColor;
            colorFigure.FullOpen = true;
            if (colorFigure.ShowDialog() == DialogResult.Cancel)
                return;
            figure.figureColor = figureColor = colorFigure.Color;
            itemsDraw();
        }

        private void trajectorySize_ValueChanged(object sender, EventArgs e)
        {
            trajectory.diameter = trajectorySize.Value;
            itemsDraw();
        }

        private void figureSize_ValueChanged(object sender, EventArgs e)
        {
            figure.radius = figureSize.Value;
            itemsDraw();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            itemsDraw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}