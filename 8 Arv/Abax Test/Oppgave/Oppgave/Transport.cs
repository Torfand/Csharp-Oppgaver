using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace Oppgave
{
    class Transport
    {
        public string RegNum;
        public decimal TopSpeed;
        private decimal Effect;
        private TransportType? Type;


        protected Dictionary<string, string> Units = new Dictionary<string, string>
        {
            {nameof(TopSpeed), " km/t" },
            {nameof(Effect), " kw" }
        };
        public Transport(string regNum, decimal topSpeed, decimal effect, TransportType? type)
        {
            RegNum = regNum;
            TopSpeed = topSpeed;
            Effect = effect;
            Type = type;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(RegNum), RegNum);
            Add(text, nameof(TopSpeed), TopSpeed);
            Add(text, nameof(Effect), Effect);
            ToStringOptional(text);
            return text.ToString();
        }

        public void Add(StringBuilder text, string name, object value)
        {
            if (value == null) return;
            text.Append("   ");
            text.Append(name);
            text.Append(" = ");
            text.Append(value);
            if (Units.ContainsKey(name)) text.Append(Units[name]);

        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(TransportType), Type);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Transport);
        }
        private bool Equals(Transport transport)
        {
            return transport != null && GetType() == transport.GetType() && RegNum == transport.RegNum;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void Compare(Transport transport2, string prefix)
        {
            var isEqual = Equals(transport2);
            var isEqualText = isEqual ? string.Empty : "Not ";
            Console.WriteLine(prefix);
            Console.WriteLine("is {0} same Vehicle.", isEqualText);
            Console.WriteLine();
        }
    }
    
}
