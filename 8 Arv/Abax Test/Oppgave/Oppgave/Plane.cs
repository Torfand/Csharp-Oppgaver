using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;

namespace Oppgave
{
    class Plane : Transport
    {
        private decimal Wingspan;
        private decimal Capacity;
        private decimal Weight;

        public Plane(string regNum, decimal topSpeed, decimal effect, TransportType? type, decimal wingspan, decimal capacity, decimal weight) : 
            base(regNum, topSpeed, effect, type)
        {
            Wingspan = wingspan;
            Capacity = capacity;
            Weight = weight;
            Units.Add(nameof(Wingspan), "m");
            Units.Add(nameof(Capacity), "Ton");
            Units.Add(nameof(Weight), "Ton");

        }

        public void StartPlane()
        {
            Console.WriteLine("Starting Plane {0} .....", RegNum);
            Thread.Sleep(1000);
            Console.WriteLine(nameof(Plane) + " "+ RegNum + "Is taking off!");
            Console.WriteLine();
        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Wingspan), Wingspan);
            Add(text, nameof(Capacity), Capacity);
            Add(text, nameof(Weight), Weight);

        }
    }
}
