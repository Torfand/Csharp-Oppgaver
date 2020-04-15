using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrations = new List<Registration>();
            var clubs = new List<Club>();
            var path =
                @"C:\Users\Torf\Documents\Start-IT\Csharp-Oppgaver\List Og Linq\Startliste\Startliste\startlist.csv";
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                reader.ReadLine();
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null) break;
                    var columns = line.Split(',').Select(n => n.Trim('"')).ToArray();
                    var registration = new Registration(columns);
                    registrations.Add(registration);
                    var club = clubs.SingleOrDefault(c => c.Name == registration.Club.Trim());
                    if (club == null)
                    {
                        club = new Club(registration.Club);
                        clubs.Add(club);
                    }
                    club.AddRegistration(registration);
                }
            }

            foreach (var club in clubs)
            {
                var stringBuilder = new StringBuilder();
                foreach (var registration in club.Registrations)
                {
                    stringBuilder.AppendLine(registration.GetText());
                }

                var clubName = new string(club.Name.Where(char.IsLetterOrDigit).ToArray());
                var fileName = "Club " + clubName + ".txt";
                int i = 2;
                while (File.Exists(fileName))
                {
                    fileName = "Club " + clubName + i + ".txt";
                    i++;
                }
                File.WriteAllText(fileName, stringBuilder.ToString());

            }
        }
    }
}