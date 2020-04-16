using System;
using System.Linq;

namespace PWGEN
{
    class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {


            if (!IsValid(args))
            {
                HelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];

            var pattern = options.PadRight(length, 'l');
            var password = string.Empty;
            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];
                pattern = pattern.Substring(0, randomIndex) +
                          pattern.Substring(randomIndex + 1, pattern.Length - randomIndex - 1);

                if (category == 'l') password += GetRandomLowerCase();
                else if (category == 'L') password += GetRandomUpperCase();
                else if (category == 'd') password += GetRandomDigit();
                else password += GetRandomSpecialCharacter();

            }
            Console.WriteLine(password);
        }

        private static char GetRandomSpecialCharacter()
        {
            var spacialChar = "!\"#¤%&/()={}[]`";
            var index = Random.Next(0, spacialChar.Length - 1);
            return spacialChar[index];
        }

        private static char GetRandomDigit()
        {
            //var random = new Random();
            return Random.Next(0, 9).ToString()[0];
        }

        private static char GetRandomUpperCase()
        {
            return GetRandomLetter('A', 'Z');
        }



        private static char GetRandomLowerCase()
        {
            return GetRandomLetter('a', 'z');
        }
        private static char GetRandomLetter(char minimum, char max)
        {
            //var random = new Random();
            return (char)Random.Next(minimum, max);
        }

        private static bool IsValid(string[] args)
        {

            if (args.Length != 2) return false;

            var lengthStr = args[0];
            var options = args[1];

            if (options.Any(character => character != 'l' && character != 'L'
                                                          && character != 'd' && character != 's'))
            {
                return false;
            }

            return lengthStr.All(char.IsDigit);
        }

        private static void HelpText()
        {
            Console.WriteLine("Password Generator <Options> <Length>");
            Console.WriteLine("Options: ");
            Console.WriteLine(" - l  = Lower case");
            Console.WriteLine(" - L  = Upper case");
            Console.WriteLine(" - d  = Digit");
            Console.WriteLine(" - s  = Special characters");
            Console.WriteLine("");
            Console.WriteLine("Example : PWGEN 14 lUssdd");
            Console.WriteLine("         Min 1 lower case");
            Console.WriteLine("         Min 1 upper case");
            Console.WriteLine("         Min 2 special characters");
            Console.WriteLine("         Min 2 digits");
        }
    }
}