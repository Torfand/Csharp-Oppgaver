using System;
using System.Collections.Generic;
using System.Text;

namespace RandomFirkanter
{
    public class Box
    {
        public int X { get; }
        public int Y { get; }
        public int StartY => Y;
        public int EndY => Y + Height;
        public int Width { get; }
        public int Height { get; }
        private int _MinSize = 3;

        public Box(Random randomize, int maxX, int maxY)
        {
            Width = randomize.Next(_MinSize, maxX);
            Height = randomize.Next(_MinSize, maxY);
            X = randomize.Next(1, maxX - Width);
            Y = randomize.Next(1, maxY - Height);
        }
    }
}
