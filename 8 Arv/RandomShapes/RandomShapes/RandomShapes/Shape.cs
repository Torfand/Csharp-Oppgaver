using System;
using System.Collections.Generic;
using System.Text;

namespace RandomShapes
{
    abstract class Shape
    {
        public int DirectionX { get; internal set; }
        public int DirectionY { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }

        protected Shape()
        {
            
        }

        protected Shape(Random randomize)
        {
            DirectionX = randomize.Next(0, 2);
            DirectionY = randomize.Next(0, 2);

        }

        public void Move()
        {
            X += DirectionX;
            Y += DirectionY;
        }
        public abstract string GetCharacter(int row, int col);
    }
}
