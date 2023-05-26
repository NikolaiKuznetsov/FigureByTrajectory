using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureByTrajectory
{
    internal class DrawTrajectory
    {
        private Graphics graphics;
        private Pen pen;
        private float x;
        private float y;
        private int diameter;

        public DrawTrajectory(Graphics graphics, Pen pen, float x, float y, int diameter) 
        {
            this.graphics = graphics;
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.diameter = diameter;
        }

        public void Draw()
        {

        }
    }
}
