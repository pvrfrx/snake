using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char c;
        public Point() { }
        public Point(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.c = p.c;
        }
        public void Draw()
        {
            if (x>-1 && y>-1)
            {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            }
        }
        public void Move(Direction direction, int offset)
        {
            if (direction == Direction.UP) this.y = this.y - offset;
            else if (direction == Direction.DOWN) this.y = this.y + offset;
            else if (direction == Direction.LEFT) this.x = this.x - offset;
            else if (direction == Direction.RIGHT) this.x = this.x + offset;
        }

        internal void Clear()
        {
            this.c = ' ';
            this.Draw();
        }

        internal bool EqualsCoordinate(Point p)
        {
            if (this.x == p.x && this.y == p.y) return true;
            else return false;
        }
    }
}
