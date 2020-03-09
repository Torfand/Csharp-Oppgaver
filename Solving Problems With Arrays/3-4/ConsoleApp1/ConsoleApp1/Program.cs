using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise4and5(args[0] == "e", args[1]);
        }
        private static void Exercise4and5(bool encrypt, string plaintext)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var code = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";
            var ciphertext = Encrypt(plaintext,
                encrypt ? alphabet : code,
                encrypt ? code : alphabet);
            Console.WriteLine(ciphertext);
            //plaintext = Decrypt(ciphertext);
        }

        private static string Encrypt(string plaintext, string alphabet, string code)
        {
            var ciphertext = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                ciphertext += EncryptChar(plaintext[i], alphabet, code);
            }

            return ciphertext;
        }

        private static char EncryptChar(char c, string alphabet, string code)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == char.ToUpper(c))
                {
                    return code[i];
                }
            }
            return c;
        }
    }
}
