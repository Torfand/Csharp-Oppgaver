using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavingMan
{
    class LeftHandedMan : Man

    {
        public LeftHandedMan(int posX, int posY, int dirX, int dirY) : 
            base(posX, posY, dirX, dirY)
        {
   
        }

        protected override void Head()
        {
            Console.WriteLine(_shouldWaveNextTime ? " o/ " : " o");
        }
        protected override void Body()
        {
            Console.WriteLine(_shouldWaveNextTime ? "/| " : " |");
        }

    }
}
