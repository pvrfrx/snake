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
        }

        internal void Move()
        {
            Point tail = listPoint.First();
            Point head = GetNextPoint();
            listPoint.Add(head);
            head.Draw();
            tail.Clear();
        }

        private Point GetNextPoint()
        {
            Point head = listPoint.Last();
            head.Move(this.direction, 1);
            return head;
        }
    }
}
