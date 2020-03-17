using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace Tre_På_Rad
{
    class BoardModel
    {
        public bool IsGameStopped { get; private set; }
        public CellContent[] Content { get; private set; }
        private readonly Random _random = new Random();
        private readonly Combo[] _winningCombinations;

        public BoardModel()
        {
            Content = new CellContent[9];
            _winningCombinations = new[]
            {
                new Combo(Content, 0, 1, 2),
                new Combo(Content, 3, 4, 5),
                new Combo(Content, 6, 7, 8),
                new Combo(Content, 0, 3, 6),
                new Combo(Content, 1, 4, 7),
                new Combo(Content, 2, 5, 8),
                new Combo(Content, 0, 4, 8),
                new Combo(Content, 2, 4, 6),
            };
        }

        public CellContent IsWinning()
        {
            return _winningCombinations.Select(c => c.IsWinning()).FirstOrDefault(x => x != CellContent.None);
        }

        public bool SetX(string posStr)
        {
            var col = posStr[0] == 'a' ? 0 : posStr[0] == 'b' ? 1 : 2;
            var row = Convert.ToInt32(posStr[1].ToString()) - 1;
            var pos = row * 3 + col;
            if (Content[pos] != CellContent.None) return false;
            Content[pos] = CellContent.Cross;
            return true;
        }

        public void SetO()
        {
            var randomIndex = _random.Next(0, 8);
            while (Content[randomIndex] != CellContent.None)
            {
                randomIndex = _random.Next(0, 8);
            }
            Content[randomIndex] = CellContent.Circle;
        }
    }
}