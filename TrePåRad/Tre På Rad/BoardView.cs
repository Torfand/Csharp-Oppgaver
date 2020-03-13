using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Tre_På_Rad
{
    
    class BoardView
    {
        

        public static void Show()
        {
          string Board =  "  a b c\n" + 
                         " ┌─────┐\n" +
                         "1│o    │\n" +
                         "2│    o│\n" +
                         "3│× ×  │\n" +
                         " └─────┘\n";
        Console.WriteLine(Board);
        }
    }
}
