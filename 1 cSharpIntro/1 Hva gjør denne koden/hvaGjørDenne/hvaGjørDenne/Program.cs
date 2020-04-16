using System;

namespace hvaGjørDenne
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            ReadInputAndUpdateCounts(range);
        }

        private static void ReadInputAndUpdateCounts(int range)
        {
            var counts = new int[range];
            string text = "Text her!";
            var letterTotal = 0;
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                letterTotal = RefreshCounts(counts, text, letterTotal);
                ShowCountnPrecantage(range, counts, letterTotal);
                ShowLetterTotal(letterTotal);
            }
        }

        private static void ShowLetterTotal(int letterTotal)
        {
            Console.WriteLine("Totale Bokstaver / Nummere : " + letterTotal);
        }

        private static void ShowCountnPrecantage(int range, int[] counts, int letterTotal)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    var Showprecantage = 100 * (double)counts[i] / letterTotal;
                    var output = "!-  " + character + "  -!" + " ---- " + counts[i] + "     Prosent anndel for denne bokstaven eller nummer : " + Showprecantage.ToString("F2") + "%";
                    Console.WriteLine(output);
                }
            }
        }

        private static int RefreshCounts(int[] counts, string text, int letterTotal)
        {
            foreach (var character in text.ToUpper())
            {
                //casting
                letterTotal++;
                counts[(int)character]++;
            }

            return letterTotal;
        }
    }
}
