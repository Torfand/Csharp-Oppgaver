using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //3-4, 3,5
            Task3();

        }

        private static void Task3()
        {
            Console.WriteLine("Skriv Text Her (!-Store Bokstaver-!: ");
            string output = "";
            var letters = LettersAndCipher(out var ciphertext);
           

            output = Encrypt(letters, output, ciphertext);
            Console.WriteLine("Kryptert Text : " + output);
            Console.WriteLine("Konvertere tilbake ? Y/N  :");
            Decrypt(output, ciphertext, letters);
        }

        private static string[] LettersAndCipher(out string[] ciphertext)
        {
            string[] letters =
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                "W", "X", "Y", "Z", "Æ", "Ø", "Å",
            };
            ciphertext = new[]
            {
                "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Å", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ø", "Æ",
                "Z", "X", "C", "V", "B", "N", "M",
            };
            return letters;
        }

        private static void Decrypt(string output, string[] ciphertext, string[] letters)
        {
            var currentlyCiphered = output;
            var answer = Console.ReadLine()?.ToUpper();
            if (answer != "Y" && answer != "N")
            {
                return;
            }

            if (answer == "Y")
            {
                output = "";
                foreach (var check in currentlyCiphered.Select(converted => converted.ToString()))
                {
                    for (int j = 0; j < ciphertext.Length; j++)
                    {
                        if (check != ciphertext[j]) continue;


                        output += letters[j];
                    }
                }
            }

            Console.WriteLine("Dekryptert Text : " + output);
        }

        private static string Encrypt(string[] letters, string output, string[] ciphertext)
        {
            Random random = new Random();
            int r = random.Next(0, 26);
            var plaintext = Console.ReadLine()?.ToUpper();

            foreach (var letter in plaintext)
            {
                var check = letter.ToString();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (check == letters[i])
                    {
                        output += ciphertext[r];
                    }
                }
            }

            return output;
        }
    }
}
