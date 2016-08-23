using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 6;
            char c1 = '*';
            Draw(x1, y1, c1);

            int x2 = 3;
            int y2 = 2;
            char c2 = '*';
            Draw(x2, y2, c2);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
