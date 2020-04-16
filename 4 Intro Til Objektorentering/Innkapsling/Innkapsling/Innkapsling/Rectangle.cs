using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Innkapsling
{
    class Rectangle
    {
        private float _Area;
        private float _Width;
     

        public Rectangle(float area, float height)
        {
            _Area = area;
            _Width = area / height;
        }

        public float Area()
        {
            return _Area;
        }
    }
}
