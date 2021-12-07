using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FigureMove.Classes
{
    class Circle : Figure
    {
        protected int radius;
        private Ellipse ellipse;

        public Circle(int centerDotX, int centerDotY, int radius, MainWindow window)
        {
            this.centerDotX = centerDotX;
            this.centerDotY = centerDotY;
            this.radius = radius;
            this.window = window;
        }

        public override void DrawBlack()
        {
            window.MyCanvas.Children.Remove(ellipse);
            ellipse = new Ellipse
            {
                Margin = new Thickness(centerDotX, centerDotY, 0, 0),
                Height = 2 * radius,
                Width = 2 * radius,
                Fill = Brushes.Black
            };
            window.MyCanvas.Children.Add(ellipse);
        }
    }
}
