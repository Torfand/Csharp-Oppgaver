using System;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            exeptionDemo();

        }

        private static void exeptionDemo()
        {
            try
            {
                //Divide By Zero Exception
                var i = 0;
                var number = 18 / i;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Prøv å dele med 0" );
            }
            //Divide By Zero Exception
            //var i = 0;
            //var number = 18 / i;
            //Index Out Of Bounds Exception
            //var a = new int[10];
            //a[15] = 1;
            //Console.WriteLine(/*a*/);
            ////Null Reference Exception
            //string x = null;
            //Console.WriteLine(/*x*/);
        }
    }
}
