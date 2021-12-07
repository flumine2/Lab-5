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
    class Rhombus : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;
        Polygon rhomb;

        public Rhombus(int centerDotX, int centerDotY, int horDiagLen, int vertDiagLen, MainWindow window)
        {
            this.centerDotX = centerDotX;
            this.centerDotY = centerDotY;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
            this.window = window;
        }

        public override void DrawBlack()
        {
            window.MyCanvas.Children.Remove(rhomb);
            rhomb = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(centerDotX, centerDotY - vertDiagLen ),
                    new Point(centerDotX + horDiagLen, centerDotY),
                    new Point(centerDotX, centerDotY + vertDiagLen ),
                    new Point(centerDotX - horDiagLen, centerDotY)
                },
                Fill = Brushes.Black
            };
            window.MyCanvas.Children.Add(rhomb);
        }
    }
}
