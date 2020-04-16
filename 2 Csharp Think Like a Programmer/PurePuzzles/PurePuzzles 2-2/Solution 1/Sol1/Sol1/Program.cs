using System;

namespace Sol1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] hashtags = { 2, 4, 6, 8};



            for (int i = 0; i < hashtags.Length; i++)
            {

                for (int x = 0; x < new[] { 4,3,2,1 }[i]; x++)
                {
                    WriteSpace();
                }

                for (int j = 0; j < hashtags[i]; j++)
                {
                    WriteHashtag();
                }



                NewLine();
            }

            Reverse(hashtags);
        }

        private static void Reverse(int[] hashtags)
        {
            Array.Reverse(hashtags);


            for (int i = 0; i < hashtags.Length; i++)
            {
                for (int x = 0; x < new[] { 1,2,3,4 }[i]; x++)
                {
                    WriteSpace();
                }

                for (int j = 0; j < hashtags[i]; j++)
                {
                    WriteHashtag();
                }

                NewLine();
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
