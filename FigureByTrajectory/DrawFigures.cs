using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureByTrajectory
{
    internal class DrawFigures
    {
        private Graphics graphics;
        private float xc;
        private float yc;
        private int n = 5; // число вершин
        public Color trajectoryColor;
        public Color figureColor;
        public int trajectoryDiameter;
        public int figureRadius;

        public DrawFigures(Graphics graphics, Color trajectoryColor, Color figureColor, float xc, float yc, int figureRadius, int trajectoryDiameter)
        {
            this.graphics = graphics;
            this.trajectoryColor = trajectoryColor;
            this.figureColor = figureColor;
            this.xc = xc;
            this.yc = yc;
            this.trajectoryDiameter = trajectoryDiameter;
            this.figureRadius = figureRadius;
        }

        public void DrawTrajectory()
        {
            graphics.DrawEllipse(new Pen(trajectoryColor, 1), xc - trajectoryDiameter / 2, yc - trajectoryDiameter / 2, trajectoryDiameter, trajectoryDiameter);
        }

        public void DrawStar()
        {
            PointF[] points = new PointF[2 * n + 1];
            double a = 50, da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? figureRadius : figureRadius / 2;
                points[k] = new PointF((float)(xc + l * Math.Cos(a)), (float)(yc + l * Math.Sin(a)));
                a += da;
            }

            graphics.DrawLines(new Pen(figureColor, 1), points);
        }
    }
}
