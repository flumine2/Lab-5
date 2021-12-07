using FigureMove.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FigureMove
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Figure figure;
        CancellationTokenSource drawToken;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Draw(CancellationToken drawToken)
        {
            while (figure.X < 800)
            {
                if (drawToken.IsCancellationRequested)
                {
                    return;
                }
                figure.MoveRight();
                await Task.Delay(40);
            }
            MyCanvas.Children.Clear();
        }

        private void ChangeFigure(Figure figure)
        {
            drawToken?.Cancel();
            drawToken = new CancellationTokenSource();
            MyCanvas.Children.Clear();
            this.figure = figure;
            Draw(drawToken.Token);
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeFigure(new Circle(0, 50, 50, this));
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeFigure(new Square(50, 100, 50, this));
        }

        private void RhombButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeFigure(new Rhombus(50, 100, 50, 50, this));
        }
    }
}
