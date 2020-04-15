using System;
using System.Collections.Generic;
using System.Text;

namespace RandomShapes
{
    class Text : Shape
    {
        private string _text;

        public Text(int x, int y, Random randomize, string text) : base(randomize)
        {
            X = x;
            Y = y;
            _text = text;

        }

        public override string GetCharacter(int row, int col)
        {
            if (row != Y || col < X || col >= X + _text.Length) return null;
            var index = col - X;
            return _text[index].ToString();
        }
    }
}
