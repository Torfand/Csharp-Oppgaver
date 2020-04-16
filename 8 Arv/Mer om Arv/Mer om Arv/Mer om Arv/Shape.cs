using System;
using System.Collections.Generic;
using System.Text;

namespace Mer_om_Arv
{
    public abstract class Shape
    {
        private protected Shape()
        {
            Console.WriteLine("Shape ctor");
        }

        public abstract double Area();

        public virtual void Show()
        {

        }
    }
}
