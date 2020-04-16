using System;
using System.Collections.Generic;
using System.Text;

namespace Mer_om_Arv
{
    public class Rectangle : Shape
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
            Console.WriteLine("rect ctor (int, int)");
        }

        public Rectangle(int side) : this(side, side)
        {
            Console.WriteLine(" rect ctor (int)");
        }

        public override double Area()
        {
            return _width * _height;
        }

    }


}
