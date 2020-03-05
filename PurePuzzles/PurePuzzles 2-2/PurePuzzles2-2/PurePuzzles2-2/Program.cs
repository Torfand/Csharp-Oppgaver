using System;

namespace PurePuzzles2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 8, 6, 4, 2 };
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int x = 0; x < new[] { 1, 2, 3, 4, 5 }[i]; x++)
                {
                    WriteSpace();
                }
                for (int j = 0; j < numbers[i]; j++)
                {
                    WriteHashtag();
                }


                NewLine();
            }
            Reverse(numbers);
        }

        private static void Reverse(int[] numbers)
        {
            Array.Reverse(numbers);


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = 0; x < new[] {5, 4, 3, 2, 1}[i]; x++)
                {
                    WriteSpace();
                }

                for (int j = 0; j < numbers[i]; j++)
                {
                    WriteHashtag();
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
