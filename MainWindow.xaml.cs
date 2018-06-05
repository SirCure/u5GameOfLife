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
            Canvas canvas = new Canvas();
            Rectangle rectangle = new Rectangle();
            List<Rectangle> grid = new List<Rectangle>();
            int height;
            int width;

            //Creates lengthwise rectangles.
            height = 1;
            width = 400;
            //for(int i = 0; i < 19; i++)
            //{
                rectangle.Height = height;
                rectangle.Width = width;
                rectangle.Fill = Brushes.Salmon;
                canvas.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, 0);
                Canvas.SetTop(rectangle, 0);
            //}
        }
    }
}
