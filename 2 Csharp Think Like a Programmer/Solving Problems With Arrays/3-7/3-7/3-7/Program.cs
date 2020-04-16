using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 10, 2, 10, 3, 10, 4, 10, 10 };
            int count = 1, tempCount;
            int frequent = numbers[0];
            int tempNR = 0;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                tempNR = numbers[i];
                tempCount = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (tempNR == numbers[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequent = tempNR;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequent, count);
            //var groups = numbers.GroupBy(v => v);
            //foreach (var group in groups)
            //{
            //    if (group.Count()-1 != 0)
            //    {
            //        Console.WriteLine("Value {0} has {1} items", group.Key, group.Count() - 1);

            //    }

            //}

        }
    }
}
