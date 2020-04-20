using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Oppgave
{
    class Car : Transport
    {
        private string Color { get; }

        public Car(string regNum, decimal topSpeed, decimal effect, TransportType? type, string color) 
            : base(regNum, topSpeed, effect, type)
        {
            Color = color;
        }

        public void Drive()
        {
            Console.WriteLine("Starting {0} {1} .... ", RegNum, nameof(TransportType.LightVehicle));
            Thread.Sleep(1000);
            Console.WriteLine(nameof(Car) + " " + RegNum + " has started driving");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Color), Color);
        }
    }
}
