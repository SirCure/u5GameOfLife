using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u5GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables.
        List<Rectangle> grid = new List<Rectangle>();
        bool[,] aliveCurrent = new bool[20, 20];
        bool[,] aliveNext = new bool[20, 20];
        Point mousePos = new Point();
        int gridX;
        int gridY;

        public MainWindow()
        {
            InitializeComponent();
            //Creates the grid out of individual rectangles.
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    grid.Add(new Rectangle());
                    grid[grid.Count - 1].MouseDown += BodyClick;
                    grid[grid.Count - 1].Height = 40;
                    grid[grid.Count - 1].Width = 40;
                    grid[grid.Count - 1].StrokeThickness = 1;
                    grid[grid.Count - 1].Stroke = Brushes.Black;
                    grid[grid.Count - 1].Fill = Brushes.White;
                    canvas.Children.Add(grid[grid.Count - 1]);
                    Canvas.SetLeft(grid[grid.Count - 1], x * 40);
                    Canvas.SetTop(grid[grid.Count - 1], y * 40);
                    aliveCurrent[x, y] = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BodyClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point currentPosition = e.GetPosition(this);
            gridX = Convert.ToInt32(Math.Floor(currentPosition.X / 40));
            gridY = Convert.ToInt32(Math.Floor(currentPosition.Y / 40));
            aliveCurrent[gridX, gridY] = true;
            grid[gridX + (gridY * 20)].Fill = Brushes.Salmon;
        }
    }
}
