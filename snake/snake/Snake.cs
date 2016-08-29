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

        internal bool IsHit(List<Figure> let)
        {
            foreach (Figure itemFigure in let)
            {
                if (IsHit(itemFigure.GetListPoint())) return true;
            }
            return false;                
        }

        private bool IsHit(List<Point> letListPoint)
        {
            foreach (Point itemPoint in letListPoint)
            {
                if (IsHit(itemPoint)) return true;
            }
            return false;
        }

        private bool IsHit(Point itemPoint)
        {
            Point headSnake = this.GetListPoint().Last();
            if (headSnake.EqualsCoordinate(itemPoint)) return true;
            else return false;
        }

     /*   internal bool IsHitTail()
        {
            throw new NotImplementedException();
        }*/

        private Point GetPrevPoint()
        {
            Point head = new Point(listPoint.First());
            head.Move(this.direction, -1);
            return head;
        }

        internal void ChangeDirection(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow && this.direction!=Direction.LEFT) this.direction = Direction.RIGHT; //нельзя разворачиваться на 180 градусов
            else if (key.Key == ConsoleKey.LeftArrow && this.direction != Direction.RIGHT) this.direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.UpArrow && this.direction != Direction.DOWN) this.direction = Direction.UP;
            else if (key.Key == ConsoleKey.DownArrow && this.direction != Direction.UP) this.direction = Direction.DOWN;
        }

        internal bool Eat(Point p)
        {
            if (listPoint.Last().EqualsCoordinate(p))
            {
                this.Grow();
                return true;
            }
            else return false;
        }

        private void Grow()
        {
            listPoint = AddItemInFirstPosition(listPoint);
        }

        private List<Point> AddItemInFirstPosition(List<Point> listPoint)
        {
            List<Point> result = new List<Point>();
            result.Add(GetPrevPoint());
            foreach (Point item in listPoint)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
