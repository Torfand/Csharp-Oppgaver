using System;
using System.ComponentModel;
using System.IO;

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
            var path = @"C:\Users\Get Academy\Documents\Ny mappe\Start-IT\TCA\C#\Oppgaver\InputOutput\InputOutput\InputOutput\data.txt";
            //var fil = File.ReadAllLines(path);
            //Console.WriteLine(fil); - 
            //Skriver ut innhold i txt fil


            using (var streamReader = File.OpenText(path))
            {
                string readLine = null;
                int lineNO = 1;
                do
                {
                   readLine = streamReader.ReadLine();
                   if (readLine != null)
                   {
                       Console.WriteLine(lineNO + ": " + readLine);
                       lineNO++;
                   }
                } while (readLine != null);
            }

            // var allLines = File.ReadAllLines(path);
            //for (var index = 0; index < allLines.Length; index++)
            //{
            //    var line = allLines[index];
            //    var lNO = (index + 1).ToString().PadLeft(3,'0');
            //    Console.WriteLine(lNO + ": " + line );
            //}
            //Skriver ut alt i fil og legger til linjenr


            //Console.WriteLine("Hello"); 
            //var input = Console.ReadLine();
            //Console.WriteLine("Hello" + input);

        }
    }
}
