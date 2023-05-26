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
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void buttonTrajectoryColor_Click(object sender, EventArgs e)
        {
            colorDialogTrajectory.Color = trajectoryColor;
            colorDialogTrajectory.FullOpen = true;
            if (colorDialogTrajectory.ShowDialog() == DialogResult.Cancel)
                return;
            trajectoryColor = colorDialogTrajectory.Color;
        }

        private void buttonBGColor_Click(object sender, EventArgs e)
        {
            colorDialogBG.Color = BGColor;
            colorDialogBG.FullOpen = true;
            if (colorDialogBG.ShowDialog() == DialogResult.Cancel)
                return;
            BGColor = colorDialogBG.Color;
        }

        private void trajectorySize_ValueChanged(object sender, EventArgs e)
        {
            graphics.DrawEllipse(new Pen(trajectoryColor, 1), pictureBox1.Width / 2 - trajectorySize.Value / 2, pictureBox1.Height / 2 - trajectorySize.Value / 2, trajectorySize.Value, trajectorySize.Value);
        }
    }
}