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
   
            var randomCipher = CreateRandomCipher(letters, rnd);

            CheckForIdenticalPlacementsAndReRandomize(randomCipher, letters);

            if (Decrypt(letters, randomCipher, out var output)) return;

            Console.WriteLine("Dekryptert Text : " + output);
           
        }

        private static bool Decrypt(string[] letters, string[] randomCipher, out string output)
        {
            output = Encrypt(letters, randomCipher);
            var currentlyCiphered = output;
            Console.WriteLine("Dekrypter Text?? : Y/N");
            var answer = Console.ReadLine()?.ToUpper();
            if (answer != "Y")
            {
                return true;
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

            return false;
        }

        private static string Encrypt(string[] letters, string[] randomCipher)
        {
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
            return output;
        }

        private static void CheckForIdenticalPlacementsAndReRandomize(string[] randomCipher, string[] letters)
        {
            for (int i = 0; i < randomCipher.Length; i++)
            {
                if (randomCipher[i] == letters[i])
                {
                   
                    Task6();
                }
            }
        }

        private static string[] CreateRandomCipher(string[] letters, Random rnd)
        {
            string[] randomCipher = letters.OrderBy(x => rnd.Next()).ToArray();
            return randomCipher;
        }
    }
}
