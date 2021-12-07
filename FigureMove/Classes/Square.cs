using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FigureMove.Classes
{
    class Square : Figure
    {
        private int size;
        Polygon square;

        public Square(int centerDotX, int centerDotY, int size, MainWindow window)
        {
            this.centerDotX = centerDotX;
            this.centerDotY = centerDotY;
            this.size = size;
            this.window = window;
        }

        public override void DrawBlack()
        {
            window.MyCanvas.Children.Remove(square);
            square = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(centerDotX - size, centerDotY - size),
                    new Point(centerDotX + size, centerDotY - size),
                    new Point(centerDotX + size, centerDotY + size),
                    new Point(centerDotX - size, centerDotY + size)
                },
                Fill = Brushes.Black
            };
            window.MyCanvas.Children.Add(square);
        }
    }
}
