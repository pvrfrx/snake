﻿using System;
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
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
