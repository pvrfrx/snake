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

            Console.ReadLine();
            Console.WriteLine("Шестой урок");

            List<char> listChar = new List<char>();
            listChar.Add('*');
            listChar.Add('/');
            listChar.Add('+');
            listChar.Add('-');

            List<Point> listPoint = new List<Point>();
            listPoint.Add(p1);
            listPoint.Add(p2);
            listPoint.Add(new Point(5,6,listChar[3]));
            listPoint.Add(new Point(7, 8, listChar[2]));

            foreach(Point p in listPoint)
            {
                p.Draw();
            }

            Console.ReadLine();
        }

    }
}
