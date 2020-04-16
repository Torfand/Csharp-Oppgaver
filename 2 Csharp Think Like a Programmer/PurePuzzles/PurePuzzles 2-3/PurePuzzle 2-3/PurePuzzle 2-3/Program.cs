using System;

namespace PurePuzzle_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = 5;
            var collums = 7;

            for (int i = -5; i <= rows; i++)
            {

                if (i == 0) continue;
                var hashtoright = (rows - Math.Abs(i)) * 2;
                for (int j = -7; j <= collums; j++)
                {
                    var hashwritten = collums - Math.Abs(j);
                    if (rows - Math.Abs(i) > collums - Math.Abs(j))
                    {

                        WriteSpace();
                    }

                    else if (hashtoright > hashwritten)
                    {
                        WriteHashtag();
                    }

                    else
                    {
                        WriteSpace();
                    }
                }
                NewLine();
            }

        }



        private static void NewLine()
        {
            Console.WriteLine(" ");
        }

        private static void WriteSpace()
        {
            Console.Write(" ");
        }

        private static void WriteHashtag()
        {
            Console.Write("#");
        }
    }
}

