using System;
using System.ComponentModel;
using System.Threading;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            task3();

        }

        private static void task3()
        {
            Console.WriteLine("Skriv Text Her (!-Store Bokstaver-!: ");
            string output = "";
            string[] letters =
            {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X","Y","Z","Æ","Ø","Å",};
            string[] ciphertext =
            {"Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Å", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ø", "Æ", "Z", "X", "C", "V", "B", "N", "M",};


            var plaintext = Console.ReadLine();
            var check = "";

            foreach (var letter in plaintext)
            {

                check = letter.ToString();
                for (int i = 0; i < letters.Length; i++)
                {

                    if (check == letters[i])
                    {
                        output += ciphertext[i];
                    }




                }
                
            }
            Console.WriteLine("Text : " + output);
        }
    }
}
