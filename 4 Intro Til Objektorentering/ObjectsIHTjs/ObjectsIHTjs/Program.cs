using System;
using System.Runtime.InteropServices;

namespace ObjectsIHTjs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obj iht JS - anonym
            //var x =  new {Width =  50, Height = 30}; 


            // C#
            var x = new Box
            {
                Height = 50,
                Width =  60
                
            };

            x.Show();
        }
    }
}
