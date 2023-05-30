using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureByTrajectory
{
    internal class DrawFigure
    {
        static public PointF[] calculatePointsFigure(int xc, int yc, int radius, int diameter, double speed)
        {
            PointF[] points = new PointF[11];
            double a = 50, da = Math.PI / 5, l;
            for (int k = 0; k < 11; k++)
            {
                l = k % 2 == 0 ? radius : radius / 2;
                points[k] = new PointF((float)(diameter / 2 * Math.Cos(speed) + xc + l * Math.Cos(a)), (float)(diameter / 2 * Math.Sin(speed) + yc + l * Math.Sin(a)));
                a += da;
            }

            return points;
        }
    }
}
