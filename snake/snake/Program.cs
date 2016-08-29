using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upBorder = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine downBorder = new HorizontalLine(0, 78, 24, '*');
            VerticalLine leftBorder = new VerticalLine(0, 0, 24, '*');
            VerticalLine rightBorder = new VerticalLine(78, 0, 25, '*');
            List<Figure> let = new List<Figure>();
 
            let.Add(upBorder);
            let.Add(downBorder);
            let.Add(leftBorder);
            let.Add(rightBorder);

            Point tailSnake1 = new Point(5, 5, '$');
            Snake snake1 = new Snake(tailSnake1, 1, Direction.DOWN);
            FoodCreator foodCreator = new FoodCreator(10, 10);
            Point food = foodCreator.CreateFood(snake1);
            while (true) //Выход по клавише Q
            {
                if (snake1.IsHit(let) /*|| snake1.IsHitTail()*/)
                {
                    break;
                }
                if (snake1.Eat(food))
                {
                    food = foodCreator.CreateFood(snake1);
                } 
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Q) break;
                    else snake1.ChangeDirection(key);
                }
                snake1.Move();
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.WriteLine("GameOver");
            Console.Read();
        }
    }
}
