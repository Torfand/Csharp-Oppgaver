using System;
using System.Collections.Generic;
using System.Text;

namespace List_og_Linq
{
    class Point
    {
        public int Y { get; }
        public int X { get; }

        public Point(int y, int x)
        {
            Y = y;
            X = x;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
