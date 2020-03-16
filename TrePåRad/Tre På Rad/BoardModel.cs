using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Tre_På_Rad
{
    public class BoardModel
    {
        public bool IsGameRunning { get; private set; }
        public CellContent[] Content { get; private set; }
        private Random _Randomize;


        public BoardModel()
        {
            Content = new CellContent[9];
            _Randomize  = new Random();
        }

        public void SetX(string posStr)
        {
            var col = posStr[0] == 'a' ? 0 : posStr[0] == 'b' ? 1 : 2;
            var row = Convert.ToInt32(posStr[1].ToString()) - 1;
            var pos = row * 3 + col;

            Content[pos] = CellContent.Cross;
          
        }

        public void SetO()
        {
            var randomIndex = _Randomize.Next(0, 8);
            while (Content[randomIndex] != CellContent.None)
            {
                randomIndex = _Randomize.Next(0, 8);
            }

            Content[randomIndex] = CellContent.Circle;
        }


        public void HasContent()
        {
            
        }
    }
}