﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {    
        public HorizontalLine(int xLeft, int xRight, int y, char c)
        {
            for (int i = xLeft; i < xRight; i++)
            {
                listPoint.Add(new Point(i, y, c));
            }
            Draw();
        }  
    }
}
