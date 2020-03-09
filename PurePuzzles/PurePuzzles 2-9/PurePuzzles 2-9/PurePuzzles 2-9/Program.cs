using System;
using System.Collections.Generic;
using System.Linq;

namespace PurePuzzles_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test";
            var wordCount = 0;
            var charactersInWord = 0;
            
            ReadInputAndCount(text, charactersInWord, wordCount);
        }

        private static void ReadInputAndCount(string text, int charactersInWord, int wordCount)
        {
            
            while (!string.IsNullOrWhiteSpace(text))
            {
            
                
                var input = Console.ReadLine();
               
                foreach (var isASpace in input.Select(word => word == ' '))
                {
                    charactersInWord++;
                    if (input.Length > charactersInWord)
                    {

                    }
                    if (!isASpace) continue;
                    charactersInWord = 0;
                    wordCount--;

                    
                }

                wordCount++;
                
                Console.WriteLine(input + " Har en lengde på : " + charactersInWord);
                Console.WriteLine("Ord Telt til nå : " + wordCount);
                Console.WriteLine("---------------------------------------------------------------");
                
                
                charactersInWord = 0;

           
                
                
            }

            
            
                
            
        }
    }
}
