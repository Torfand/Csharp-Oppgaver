using System;
using System.Collections.Generic;
using System.Text;

namespace Stjerner_Med_Arv
{
    class MoveableStar : Star
    {
        private int _speedX;
        private int _speedY;


        public MoveableStar(int x, int y, int phase, int speedX, int speedY)
            : base(x, y, phase)
        {
            _speedX = speedX;
            _speedY = speedY;
        }

        public MoveableStar(Random random) : base(random)
        {
            _speedX = random.Next(-1, 2);
            _speedY = random.Next(-1, 2);
        }

        

        public override void Update()
        {
            base.Update();
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;
            if (_x <= 1) _speedX = 1;
            if (_x >= windowWidth -1)_speedX = -1 ;
            if (_y <= 1)_speedY = 1;
            if (_y >= windowHeight - 1) _speedY = -1;
            _x += _speedX;
            _y += _speedY;


        }
    }
}
