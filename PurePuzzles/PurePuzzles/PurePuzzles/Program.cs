using System;
using System.Xml;

namespace PurePuzzles
{
    class Program
    {
        private static int _hashes;
        private static int _space;

        static void Main(string[] args)
        {
            _hashes = 10;
            _space = 1;
            for (int j = 0; j < _space; j++)
            {
                WriteSpace();
            }
            for (int i = 0; i < _hashes; i++)
            {

                WriteHashtag();
            }

            
            
            
            SecondLine();
        }

     

        private static void SecondLine()
        {
            NewLine();
            _hashes = 8;
            _space++;
            for (var j = 0; j < _space; j++)
            {
                WriteSpace();
            }
            for (var i = 0; i < _hashes; i++)
            {
                WriteHashtag();
            }

            ThirdLine();
        }

        private static void ThirdLine()
        {
            NewLine();
            _hashes = 6;
            _space++;

            for (var j = 0; j < _space; j++)
            {
                WriteSpace();
            }
            for (var i = 0; i < _hashes; i++)
            {
                WriteHashtag();
            }
            FourthLine();
        }

        private static void FourthLine()
        {
            NewLine();
            _hashes = 4;
            _space++;

            for (var j = 0; j < _space; j++)
            {
                WriteSpace();
            }
            for (var i = 0; i < _hashes; i++)
            {
              WriteHashtag();
            }

            FinalLine();
        }

        private static void FinalLine()
        {
            NewLine();
            _hashes = 2;
            _space++;

            for (var j = 0; j < _space; j++)
            {
                WriteSpace();
            }
            for (var i = 0; i < _hashes; i++)
            {
                WriteHashtag();
            }
        }


        private static void NewLine()
        {
            Console.WriteLine(" ");
        }

        private static void WriteSpace()
        {
            Console.Write(" ");
        }

        private static void WriteHashtag()
        {
            Console.Write("#");
        }
    }
}
