using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureByTrajectory
{
    internal class DrawFigure
    {
        private Graphics graphics;
        private float xc;
        private float yc;
        public Color figureColor;
        public int radius;
        public float diameter;
        public double speed = 0.0;
        public double breathingRate = 0.0;

        public DrawFigure(Graphics graphics, Color figureColor, float xc, float yc, int radius, int diameter)
        {
            this.graphics = graphics;
            this.figureColor = figureColor;
            this.xc = xc;
            this.yc = yc;
            this.radius = radius;
            this.diameter = diameter;
        }

        public void Draw()
        {
            PointF[] points = new PointF[11];
            double a = 50, da = Math.PI / 5, l;
            if (speed > 2 * Math.PI) speed = 0.0;
            radius += (int)(Math.Sin(breathingRate) * 2);
            for (int k = 0; k < 11; k++)
            {
                l = k % 2 == 0 ? radius : radius / 2;
                points[k] = new PointF((float)(200 / 2 * Math.Cos(speed) + xc + l * Math.Cos(a)), (float)(200 / 2 * Math.Sin(speed) + yc + l * Math.Sin(a)));
                a += da;
            }

            graphics.DrawLines(new Pen(figureColor, 1), points);
        }
    }
}
