using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace FlaskeSim
{
    class Bottle
    {
        public int Capacity { get; }
        public int Content { get; private set; }

        public Bottle(int capacity)
        {
            Capacity = capacity;

        }

        public bool Fill(int volume)
        {
            if (volume + Content > Capacity) return false;
            Content += volume;
            return true;



        }
        public bool FillToCap(Bottle otherBottle)
        {
            var VolumeNeeded = Capacity - Content;
            if (otherBottle.Content < VolumeNeeded) return false;
            Content = Capacity;
            otherBottle.Remove(VolumeNeeded);
            return true;
        }

        private void Remove(in int volumeNeeded)
        {
            Content -= volumeNeeded;
        }

        public int EmptyFlask()
        {
            var content = Content;
            Content = 0;
            return content;
        }
    

        public bool isEmpty()
        {
            return Content == 0;

        }

        public void FillToCapFromVoid()
        {
            Content = Capacity;

        }
    }


}
