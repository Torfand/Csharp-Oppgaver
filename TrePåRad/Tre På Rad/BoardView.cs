using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Tre_På_Rad
{

    class BoardView
    {

        public static void Show(BoardModel boardModel)
        {
            Console.Clear();
            var content = boardModel.Content;
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");

            ShowOneLine(0, content);
            ShowOneLine(3, content);
            ShowOneLine(6, content);

            Console.WriteLine(" └─────┘");
        }

        private static void ShowOneLine(int startIndex, CellContent[] content)
        {
            var lineNO = 1 + startIndex / 3;
            Console.Write(lineNO + "│");
            for (int i = startIndex; i < startIndex + 3; i++)
            {
                
               if (i > startIndex) Console.Write(' ');

                var isBlank = content[i] == CellContent.None;
                var isCross = content[i] == CellContent.Cross;
                Console.Write(isBlank ? ' ' : isCross ? '×' : 'o');

            }

            Console.WriteLine("│");
        }

        /*  a b c
         ┌─────┐
        1│     │
        2│     │
        3│     │
         └─────┘
         */
    }
}
