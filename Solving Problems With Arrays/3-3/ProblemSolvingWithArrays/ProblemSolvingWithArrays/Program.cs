using System;

namespace ProblemSolvingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"Sortert = {IsSorted(numbers)}");
            numbers = new[] {1, 2, 3, 5, 7, 8};
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"Sortert = {IsSorted(numbers)}");
        }

        private static bool IsSorted(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }

            return true;
        }


    }
}
