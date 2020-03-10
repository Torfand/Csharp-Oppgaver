using System;
using System.Dynamic;
using System.Linq;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Task6();
        }

        private static void Task6()
        {
            string[] letters =
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                "W", "X", "Y", "Z", "Æ", "Ø", "Å",
            };
            Console.WriteLine("NEW INSTANCE :  ___ ");
            Random rnd = new Random();
   
            string[] randomCipher = letters.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < randomCipher.Length; i++)
            {
                if (randomCipher[i] == letters[i])
                {
                    Console.Write("Dupe Detected ---- ");
                    Task6();

                }
            }

            var output = "";
            var plaintext = Console.ReadLine().ToUpper();
            foreach (var Letter in plaintext)
            {
                var check = Letter.ToString();
                for (int i = 0; i < letters.Length; i++)
                {

                    if (check == letters[i])
                    {
                        output += randomCipher[i];
                    }
                }
            }
            Console.WriteLine("Kryptert Text :  " + output);
            var currentlyCiphered = output;
            Console.WriteLine("Dekrypter Text?? : Y/N");
            var answer = Console.ReadLine()?.ToUpper();
            if (answer != "Y")
            {

                Console.WriteLine("Avslutter Programm : ");
                return;
            }

            if (answer == "Y")
            {
                output = "";
                foreach (var check in currentlyCiphered.Select(converted => converted.ToString()))
                {
                    for (int j = 0; j < randomCipher.Length; j++)
                    {
                        if (check != randomCipher[j]) continue;


                        output += letters[j];
                    }
                }
            }

            Console.WriteLine("Dekryptert Text : " + output);
           
        }
    }
}
