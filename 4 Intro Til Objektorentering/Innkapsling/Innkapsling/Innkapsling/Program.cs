using System;
using System.Linq;

namespace Innkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle[]
            {
                new Rectangle(21, 3),
                new Rectangle(22, 11),
                new Rectangle(30, 6),

            };
            var totArea = r.Sum(r => r.Area());
            Console.WriteLine(totArea);

        }
    }
}
