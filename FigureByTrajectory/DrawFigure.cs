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
        public Color figureColor;
        private float xc;
        private float yc;
        private int n = 5; // число вершин
        public int radius;
        public float diameterX;
        public float diameterY = 0;

        public DrawFigure(Graphics graphics, Color figureColor, float xc, float yc, int radius, int diameter)
        {
            this.graphics = graphics;
            this.figureColor = figureColor;
            this.xc = xc;
            this.yc = yc;
            this.radius = radius;
            diameterX = diameter;
        }

        public void Draw()
        {
            PointF[] points = new PointF[2 * n + 1];
            double a = 50, da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? radius : radius / 2;
                points[k] = new PointF((float)(xc + diameterX / 2 + l * Math.Cos(a)), (float)(yc + diameterY / 2 + l * Math.Sin(a)));
                a += da;
            }

            graphics.DrawLines(new Pen(figureColor, 1), points);
        }
    }
}
