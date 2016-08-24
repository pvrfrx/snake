using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        private int widht = 0;
        private int height = 0;
        static char c = 'O';
        
        public FoodCreator(int widht, int height)
        {
            this.widht = widht;
            this.height = height;
        }
        public Point CreateFood()
        {
            Random rand = new Random();
            Point p = new Point(rand.Next(this.widht), rand.Next(this.height), c);
            p.Draw();
            return p;
        }
    }
}
