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
            Rectangle rectangle = new Rectangle();
            List<Rectangle> grid = new List<Rectangle>();

            //Creates lengthwise rectangles.
            for (int i = 0; i < 21; i++)
            {
                grid.Add(new Rectangle());
                grid[grid.Count - 1].Height = 2;
                grid[grid.Count - 1].Width = 800;
                grid[grid.Count - 1].Fill = Brushes.Black;
                Canvas.SetLeft(grid[grid.Count - 1], 0);
                Canvas.SetTop(grid[grid.Count - 1], i * 40);
                canvas.Children.Add(grid[grid.Count - 1]);
            }

            //Creates heightwise rectangles.
            for (int i = 0; i < 21; i++)
            {
                grid.Add(new Rectangle());
                grid[grid.Count - 1].Height = 800;
                grid[grid.Count - 1].Width = 2;
                grid[grid.Count - 1].Fill = Brushes.Black;
                Canvas.SetLeft(grid[grid.Count - 1], i * 40);
                Canvas.SetTop(grid[grid.Count - 1], 0);
                canvas.Children.Add(grid[grid.Count - 1]);
            }
        }
    }
}
