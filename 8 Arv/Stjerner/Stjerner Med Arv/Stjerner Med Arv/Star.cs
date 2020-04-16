using System;
using System.Collections.Generic;
using System.Text;

namespace Stjerner_Med_Arv
{
    class Star
    {
        private string _chars = ".-x***x-.";
        protected int _x;
        protected int _y;
        private int _phase;

        public Star(int x, int y, int phase)
        {
            _x = x;
            _y = y;
            _phase = phase;
        }

        public Star(Random random)
        {
            _x = random.Next(1, Console.WindowWidth -1);
            _y = random.Next(1, Console.WindowHeight -1);
            _phase = random.Next(0, _chars.Length);

        }

        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.WriteLine(_chars[_phase]);
        }

        public virtual void Update()
        {
            _phase++;
            //if (_phase == _chars.Length) _phase = 0;

        }
    }

}
