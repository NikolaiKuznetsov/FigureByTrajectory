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
		// Инициализируем переменные со значениями из файла конфигурации
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
            InitializeComponent();          // инициализируем стандарные компоненты WinForms
            // Задаём координаты центра блока рисования
            xc = pictureBox1.Width / 2;     
            yc = pictureBox1.Height / 2;

            DoubleBuffered = true;         // Включаем двойную буферизацию для решения проблем мерцания, связанных с несколькими операциями рисования
        }

        /// <summary>
        /// Метод, срабатывающий при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
			// задаем цвет и положения trackBar`ов относительно значений в файле конфигурации при загрузке формы
            pictureBox1.BackColor = Properties.Settings.Default.BGColor;
            trajectorySize.Value = Properties.Settings.Default.trajectoryDiameter;
            figureBreathingRate.Value = Properties.Settings.Default.figureBreathingRate;
            figureSize.Value = Properties.Settings.Default.figureSize;
            figureSpeed.Value = Properties.Settings.Default.figureSpeed;
        }

        /// <summary>
        /// Метод, срабатывающий при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			// сохраняем в файлы конфигурации значения при закрытии формы
            Properties.Settings.Default.figureRadius = figureRadius;
            Properties.Settings.Default.breathingRate = breathingRate;
            Properties.Settings.Default.figureSize = figureSize.Value;
            Properties.Settings.Default.figureSpeed = figureSpeed.Value;
            Properties.Settings.Default.trajectoryDiameter = trajectorySize.Value;
            Properties.Settings.Default.figureBreathingRate = figureBreathingRate.Value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Метод, который срабатывает при нажатии на кнопку "Цвет фона"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBGColor_Click(object sender, EventArgs e)
        {
            colorDialogBG.Color = Properties.Settings.Default.BGColor;  // подтягиваем цвет фона из настроек
            colorDialogBG.FullOpen = true;                              // открываем диалог выбора цвета
            if (colorDialogBG.ShowDialog() == DialogResult.Cancel)      // проверяем, как был закрыт диалог
                return;                                                 // если крестиком, то ничего не делая, закрываем диалог
            Properties.Settings.Default.BGColor = colorDialogBG.Color;  // иначе записываем новый цвет в настройки
            pictureBox1.BackColor = colorDialogBG.Color;                // окрашиваем область рисования в выбранный цвет
        }

        /// <summary>
        /// Метод, который срабатывает при нажатии на кнопку "Цвет траектории"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrajectoryColor_Click(object sender, EventArgs e)
        {
            colorDialogTrajectory.Color = Properties.Settings.Default.trajectoryColor;
            colorDialogTrajectory.FullOpen = true;
            if (colorDialogTrajectory.ShowDialog() == DialogResult.Cancel)
                return;
            Properties.Settings.Default.trajectoryColor = colorDialogTrajectory.Color;
            trajectoryPen = new Pen(colorDialogTrajectory.Color, 1);                    // создаем карандаш для рисования фигуры с выбранным цветом
        }

        /// <summary>
        /// Метод, который срабатывает при нажатии на кнопку "Цвет фигуры"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFigureColor_Click(object sender, EventArgs e)
        {
            colorFigure.Color = Properties.Settings.Default.figureColor;
            colorFigure.FullOpen = true;
            if (colorFigure.ShowDialog() == DialogResult.Cancel)
                return;
            Properties.Settings.Default.figureColor = colorFigure.Color;
            figurePen = new Pen(colorFigure.Color, 1);
        }

        /// <summary>
        /// Метод, который срабатывает при изменении trackBar`a "Размер траектории"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trajectorySize_ValueChanged(object sender, EventArgs e)
        {
            trajectoryDiameter = trajectorySize.Value;  // получаем значение из trackBar`a изаписываем в переменную для дальнейшего рисования
        }

        /// <summary>
        /// Метод, вызываемый таймером с интервалом 40мс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFigureSpeed_Tick(object sender, EventArgs e)
        {
            // проверяем увеличивается или уменьшаеся фигура
            if (breathingRate)
            {
                // увеличиваем фигуру
                figureRadius += figureSize.Value / figureBreathingRate.Value;
                if (figureRadius >= figureSize.Value * 2)   // проверяем, больше или равен радиус фигуры, указанному в trackBar`e размеру
                    breathingRate = false;
            }
            else
            {
                // уменьшаем фигуру
                figureRadius -= figureSize.Value / figureBreathingRate.Value;
                if (figureRadius <= 10)
                    breathingRate = true;
            }

            // скорость движения фигуры по траектории
            if (speed > 2 * Math.PI) speed = 0.0;
            speed += (double)figureSpeed.Value / 10;

            // стандартная функция, которая сообщает приложению, что нужно вызвать метод перерисовки
            Invalidate(true);
        }

        /// <summary>
        /// Метод для автоматического рисования при изменении любого из параметров отрисовки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(trajectoryPen, xc - trajectoryDiameter / 2, yc - trajectoryDiameter / 2, trajectoryDiameter, trajectoryDiameter);    // рисуем траекторию (круг)
            e.Graphics.DrawLines(figurePen, DrawFigure.calculatePointsFigure(xc, yc, figureRadius, trajectoryDiameter, speed));                         // рисуем фигуру (пятиконечную звезду)
        }
    }
}