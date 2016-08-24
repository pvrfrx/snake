using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(direction, i);
                listPoint.Add(p);
            }
            this.Draw();
        }

        internal void Move()
        {
            Point tail = listPoint.First();
            Point head = GetNextPoint();
            listPoint.Add(head);
            tail.Clear();
            head.Draw();
            listPoint.Remove(tail);
            
        }

        private Point GetNextPoint()
        {
            Point head = new Point(listPoint.Last());
            head.Move(this.direction, 1);
            return head;
        }

        internal void ChangeDirection(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow) this.direction = Direction.RIGHT;
            else if (key.Key == ConsoleKey.LeftArrow) this.direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.UpArrow) this.direction = Direction.UP;
            else if (key.Key == ConsoleKey.DownArrow) this.direction = Direction.DOWN;
        }

    }
}
