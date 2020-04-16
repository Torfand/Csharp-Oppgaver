using System;
using System.Threading;

namespace Tre_På_Rad
{
    class Program
    {
        static void Main(string[] args)
        {


            var boardModel = new BoardModel();
            while (true)
            {
                BoardView.Show(boardModel);
                Console.Write("Skriv Hvor du vil sette 'X', (Feks: a2)");
                var validInput = true;
                do
                {
                    if(!validInput) Console.WriteLine("Skriv igjen");
                    var pos = Console.ReadLine();
                    
                    validInput = boardModel.SetX(pos);
                    
                } while (!validInput);

                BoardView.Show(boardModel);

                Thread.Sleep(1000);

                boardModel.SetO();

            }



        }
    }
}
