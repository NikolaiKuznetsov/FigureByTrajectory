using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureByTrajectory
{
    internal class DrawTrajectory
    {
        private Graphics graphics;
        public Color trajectoryColor;
        private float xc;
        private float yc;
        public int diameter;

        public DrawTrajectory(Graphics graphics, Color trajectoryColor, float xc, float yc, int diameter) 
        {
            this.graphics = graphics;
            this.trajectoryColor = trajectoryColor;
            this.xc = xc;
            this.yc = yc;
            this.diameter = diameter;
        }

        public void Draw()
        {
            graphics.DrawEllipse(new Pen(trajectoryColor, 1), xc - diameter / 2, yc - diameter / 2, diameter, diameter);
        }
    }
}
