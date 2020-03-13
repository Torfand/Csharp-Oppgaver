using System;

namespace Referansetype_Vs_Verditype
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Test1();
            //Test2();
            //Test3(); // String
            //Test4();
            Test5(); //sideEffects

        }

        private static void Test5()
        {
            var box = new Box
            {
                Height = 20,
                Width = 30
            };
            int i = 7;
            Console.WriteLine("FØR :   " + i);
            Console.WriteLine("FØR :   " + box.Height);
            DoSomthing(box, i);
            Console.WriteLine("FØR :   " + box.Height);
        }

        private static void DoSomthing(Box box,  int i)
        {
            i += 10;
            box.Height += 10;


        }


        private static void Test4()
        {
            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 40,
                Width = 80
            };
            a = b;
        }

        private static void Test3()
        {

            //  string Interning c# --
            // Strings are immutable, which means we are creating new memory
            // every time instead of working on existing memory.

            //----------------------------

            // String Immutable  c#
            //The Intern method uses the intern pool to search for a string
            //equal to the value of "strname". If such a string exists, i
            //ts reference in the intern pool is returned.
            //If the string does not exist, a reference to str is
            //added to the intern pool, then that reference is returned.


            string a = "A";
            string b = "A";
            if (a == b) Console.WriteLine("A og B er like");
            else Console.WriteLine("A og B er ikke Like");

        }

        private static void Test2()
        {
            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 20,
                Width = 30
            };
            if (a == b) Console.WriteLine("A og B er like");
            else Console.WriteLine("A og B er ikke Like");
            if (a.Height == b.Height) Console.WriteLine("A... og B.... er like");
            else Console.WriteLine("A og B er ikke Like");



        }

        private static void Test1()
        {

            /*
            *2 typer i c#,
            * Referansetyper
            *- Objekter 
            * &
            *
            * Verdiyper
            *-int, bool, double, char, float
            */

            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 40,
                Width = 80
            };
            var c = a;

            c.Height = 99;
            Console.WriteLine(a.Height);
        }
    }
}
