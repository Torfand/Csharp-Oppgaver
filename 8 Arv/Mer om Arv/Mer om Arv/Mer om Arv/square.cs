using System;
using System.Collections.Generic;
using System.Text;

namespace Mer_om_Arv
{
    public class Square : Rectangle
    {
        private int _side;

        public Square(int side) : base(side)
        {
            _side = side;

            Console.WriteLine("square Ctor");
        }

        public override double Area()
        {
            return _side * _side;
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
