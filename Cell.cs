using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace u5GameOfLife
{
    class Cell
    {
        Rect rect = new Rect();
        public bool alive;
        public int height;
        public int width;
        public Point pos;

        public void cell(Point point)
        {
            pos = point;
        }
    }
}
