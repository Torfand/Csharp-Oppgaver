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
                var pos = Console.ReadLine();
            
                boardModel.HasContent();
                
                boardModel.SetX(pos);
                BoardView.Show(boardModel);

                Thread.Sleep(1000);

                boardModel.SetO();

            }


        }
    }
}
