using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureByTrajectory
{
    /// <summary>
    /// Класс для расчёта точек пятиконечной звезды
    /// </summary>
    internal class DrawFigure
    {
        /// <summary>
        /// Статический метод для расчёта точек пятиконечной звезды
        /// </summary>
        /// <param name="xc">X-центра поля</param>
        /// <param name="yc">Y-центра поля</param>
        /// <param name="radius">Радиус фигуры</param>
        /// <param name="diameter">Диаметр траектории</param>
        /// <param name="speed">Скорость движения фигуры</param>
        /// <returns>Точки с координатами отрисовки фигуры</returns>
        static public PointF[] calculatePointsFigure(int xc, int yc, int radius, int diameter, double speed)
        {
            PointF[] points = new PointF[11];   // инициализируем массив floating-точек
            double a = 50, da = Math.PI / 5, l; // задаём начальные значения
            for (int k = 0; k < 11; k++)
            {
                l = k % 2 == 0 ? radius : radius / 2;   // проверяем, во внешнем или во внутреннем радиусе ставить точку
                // добавляем в массив новую точку по координатам, расчитанным по формуле
                points[k] = new PointF((float)(diameter / 2 * Math.Cos(speed) + xc + l * Math.Cos(a)), (float)(diameter / 2 * Math.Sin(speed) + yc + l * Math.Sin(a)));
                a += da; // увеличиваем угол
            }

            return points;
        }
    }
}
