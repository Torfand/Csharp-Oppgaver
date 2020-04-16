using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Club
    {
        public string Name { get; }
        public List<Registration> Registrations { get; }

        public Club()
        {
            Registrations = new List<Registration>();
        }

        public Club(string name) : this()
        {
            Name = name;
        }

        public void AddRegistration(Registration reg)
        {
            Registrations.Add(reg);
        }
    }
}
