using System;
using System.Collections.Generic;
using System.Text;

namespace Oppgave
{
    class Boat : Transport
    {
        public decimal GrossTonnage { get; }

        public Boat(string regNum, decimal topSpeed, decimal effect, TransportType? type, decimal grossTonnage) 
            : base(regNum, topSpeed, effect, type)
        {
            GrossTonnage = grossTonnage;
          
             Units.Add(nameof(GrossTonnage), "kg");
            Units[nameof(TopSpeed)] = "Knot";
        }
        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(GrossTonnage), GrossTonnage);
        }
    }
}
