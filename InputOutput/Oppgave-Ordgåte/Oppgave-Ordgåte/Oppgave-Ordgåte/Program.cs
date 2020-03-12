using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oppgave_Ordgåte
{
    class Program
    {
        static void Main(string[] args)
        {
            var Words = ReadTextFromFile();
            var wordCount = 10;
            while (wordCount > 0)
            {
                var HasFoundWords = GetWordpuzzle(Words);
                if (HasFoundWords)
                {
                    wordCount--;
                }
            }
            
        }

        private static bool GetWordpuzzle(string[] Words)
        {
            var RandomIndex = new Random().Next(Words.Length);
            var ChosenWord = Words[RandomIndex];
            Console.Write(ChosenWord + "    ___   ");
            foreach (var word in Words)
            {
                //if (i % 1000 == 0) Console.Write(". ");
                if (!isLastpartEqualTofirstPart(ChosenWord, word)) continue;
                Console.WriteLine(word);
                return true;
            }

            Console.WriteLine("Fant ikke ord!");
            return false;
        }

        private static bool isLastpartEqualTofirstPart(string word1, string word2)
        {
            return 
                isLastpartEqualTofirstPart(4, word1, word2)
                || isLastpartEqualTofirstPart(5, word1, word2)
                || isLastpartEqualTofirstPart(6, word1, word2);
        }
        private static bool isLastpartEqualTofirstPart(int Clength, string word1, string word2)
        {
            var lastPart = word1.Substring(word1.Length - Clength, Clength);
            var firstPart = word2.Substring(0, Clength);
            return lastPart == firstPart;
        }

        private static string[] ReadTextFromFile()
        {
            const string path =
                @"C:\Users\Get Academy\Documents\Ny mappe\Start-IT\TCA\C#\Oppgaver\InputOutput\Oppgave-Ordgåte\Oppgave-Ordgåte\Oppgave-Ordgåte\Ordliste.txt";
            var Text = File.ReadLines(path, Encoding.UTF8);
            var List = new List<string>();
            var LastWord = string.Empty;

            foreach (var Line in Text)
            {
                var parts = Line.Split('\t');
                var Word = parts[1];
                if (Word != LastWord && Word.Length > 7 && !Word.Contains("-")) List.Add(Word);


                LastWord = Word;
            }

            return List.ToArray();
        }
    }
}
