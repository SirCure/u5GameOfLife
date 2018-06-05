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
        public MainWindow()
        {
            InitializeComponent();

            //Global Variables.
            List<Rectangle> grid = new List<Rectangle>();

            for(int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 20; x++)
                {
                    grid.Add(new Rectangle());
                    grid[grid.Count - 1].Height = 40;
                    grid[grid.Count - 1].Width = 40;
                    grid[grid.Count - 1].StrokeThickness = 1;
                    grid[grid.Count - 1].Stroke = Brushes.Black;
                    canvas.Children.Add(grid[grid.Count - 1]);
                    Canvas.SetLeft(grid[grid.Count - 1], x * 40);
                    Canvas.SetTop(grid[grid.Count - 1], y * 40);
                }
            }
        }
    }
}
