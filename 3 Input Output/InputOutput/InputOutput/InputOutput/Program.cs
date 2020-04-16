using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace InputOutput
{
    class Program
    {
        /*
         *Input output skjerm/Tattatur
         *Input Output FIl
         *
         * Encoding
         * Using - for og dispose fil resusser
         * List<string>() -
         * ToArray
         * string.contains
         * string.length
         * string.substring
         *
         *
         *Random
         *
         *
         */

        static void Main(string[] args)
        {
            //var path = @"C:\Users\Get Academy\Documents\Ny mappe\Start-IT\TCA\C#\Oppgaver\InputOutput\InputOutput\InputOutput\data.txt";
            ////var fil = File.ReadAllLines(path);
            ////Console.WriteLine(fil); - 
            ////Skriver ut innhold i txt fil

            //var List = ListFromFile(path);

            //Lines(List); 

            ////var allLines = File.ReadAllLines(path);
            ////for (var index = 0; index < allLines.Length; index++)
            ////{
            ////    var line = allLines[index];
            ////    var lNO = (index + 1).ToString().PadLeft(3, '0');
            ////    Console.WriteLine(lNO + ": " + line);
            ////}
            ////Skriver ut alt i fil og legger til linjenr


            ////Console.WriteLine("Hello"); 
            ////var input = Console.ReadLine();
            ////Console.WriteLine("Hello" + input);
            encondeTEst();
        }

        private static void encondeTEst()
        {
            var path = @"C:\Users\Get Academy\Documents\Ny mappe\Start-IT\TCA\C#\Oppgaver\InputOutput\InputOutput\InputOutput\data.txt";
            var Text = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(Text);
        }

        private static void Lines(string[] List)
        {
            for (var index = 0; index < List.Length; index++)
            {
                var line = List[index];
                Console.WriteLine(index + "  " + line);
            }
        }

        private static string[] ListFromFile(string path)
        {
            var List = new List<string>();
            using (var streamReader = File.OpenText(path))
            {
                string readLine = null;

                do
                {
                    readLine = streamReader.ReadLine();

                    if (readLine != null)
                    {
                        List.Add(readLine);
                    }
                } while (readLine != null);
            }

            return List.ToArray();
        }
    }
}
