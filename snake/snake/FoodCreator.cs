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
        Random rand = new Random();
        public FoodCreator(int widht, int height)
        {
            this.widht = widht;
            this.height = height;
        }
        public Point CreateFood()
        {
            int x = rand.Next(this.widht);
            int y = rand.Next(this.height);
            Point p = new Point(x,y,c);
            p.Draw();
            return p;
        }
    }
}
