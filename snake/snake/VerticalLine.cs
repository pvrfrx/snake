using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yUp, int yDown, char c)
        {
            for (int i = yUp; i < yDown; i++)
            {
                listPoint.Add(new Point(x, i, c));
            }
            Draw();
        }
    }
}
