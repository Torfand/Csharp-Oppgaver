using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace PurePuzzles_2_1_solution_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = {10 ,8 , 6 , 4 , 2};
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int x = 0; x < new[] {1, 2, 3, 4, 5}[i]; x++)
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
