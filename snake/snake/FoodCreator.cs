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
        public Point CreateFood(Snake snake)
        {
            Random rand = new Random();
            int x=1;
            int y=1; 
            for (int i = 0; i < 1; i++)
            {
                x = rand.Next(this.widht);
                y = rand.Next(this.height); 
                foreach (Point item in snake.GetListPoint())
                {
                    if (item.x==x && item.y==y)
                    {
                        i--;
                        break;
                    }
                }
            }
            
            Point p = new Point(x, y, c);
            p.Draw();
            return p;
        }
    }
}
