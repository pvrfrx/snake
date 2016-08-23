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
            Point p1 = new Point(1, 2, '*');
            p1.Draw();


            Point p2 = new Point(3,4,'&');
            p2.Draw();

            HorizontalLine HL1 = new HorizontalLine(5, 10, 5, '^');
            HL1.Draw();

            Console.ReadLine();
           
        }

    }
}
