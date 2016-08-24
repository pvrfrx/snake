using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> listPoint = new List<Point>();
        public void Draw()
        {
            foreach (Point item in listPoint)
            {
                item.Draw();
            }
        }
    }
}
