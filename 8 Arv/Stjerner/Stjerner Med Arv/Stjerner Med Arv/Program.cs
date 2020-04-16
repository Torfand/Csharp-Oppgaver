using System;
using System.Threading;

namespace Stjerner_Med_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new Star[]
           {
                new Star(random),
                new Star(random),
                new Star(random),
                new MoveableStar(random),
                new MoveableStar(random),
                new MoveableStar(random),

           };
            while (true)
            {
               Console.Clear();
               foreach (var star in stars)
               {
                   star.Show();
                   star.Update();
               }

               Console.CursorLeft = 0;
               Console.CursorTop = 0;
               Thread.Sleep(100);
            }
        }
    }
}
