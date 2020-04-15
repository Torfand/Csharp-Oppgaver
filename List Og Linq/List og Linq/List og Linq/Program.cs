using System;
using System.Collections.Generic;
using System.Linq;

namespace List_og_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //DemoLinq();
            //Demolist1();
            //demolist2();

        }

        private static void DemoLinq()
        {
            var list = GetPoints();
            //var point = list.FirstOrDefault(p => p.X == p.Y);

            //Console.WriteLine(point?.ToString() ?? "Null");
            var points = list.Where(p => p.X == p.Y);
            foreach (var p in points)
            {
                Console.WriteLine(p);
            }

            //if (list.Any(p => p.X == p.Y)) { }
            //if (list.All(p => p.X == p.Y)) { }




        }

        private static void demolist2()
        {
            var list = GetPoints();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();

            foreach (var point in list)
            {
                Console.Write(point + " ");
            }

            Console.WriteLine();
        }

        private static List<Point> GetPoints()
        {
            var list = new List<Point>();
            var random = new Random();
            var count = 0;
            while (true)
            {
                var point = new Point(random.Next(0, 10), random.Next(0, 10));
                list.Add(point);
                if (random.Next(0, 50) == 5) break;
            }

            return list;
        }

        private static void Demolist1()
        {
            var list = new List<int>();
            var random = new Random();
            var count = 0;
            while (true)
            {
                var number = random.Next(0, 100);
                list.Add(number);
                if (random.Next(0, 10) == 5) break;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
            list[0] = 9;
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
