using System;

namespace PurePuzzles2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 8;
            int[] hashtags = { 2, 4, 6, 8, 8, 6, 4, 2 };



            foreach (var hash in hashtags)
            {
                for (int j = 0; j < (space - hash) / 2;j++)
                {
                    WriteSpace();
                }

                for (int i = 0; i < hash; i++)
                {
                    WriteHashtag();
                }

                NewLine();
            }



        }

        //private static void Reverse(int[] numbers)
        //{
        //    Array.Reverse(numbers);


        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int x = 0; x < new[] {5, 4, 3, 2, 1}[i]; x++)
        //        {
        //            WriteSpace();
        //        }

        //        for (int j = 0; j < numbers[i]; j++)
        //        {
        //            WriteHashtag();
        //        }

        //        NewLine();
        //    }
        //}

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
