using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FigureMove.Classes
{
    abstract class Figure
    {
        protected int centerDotX;
        protected int centerDotY;
        protected MainWindow window;

        public int X
        {
            get => centerDotX;
        }

        public abstract void DrawBlack();

        public void MoveRight()
        {
            DrawBlack();
            centerDotX += 1;
        }
    }
}
