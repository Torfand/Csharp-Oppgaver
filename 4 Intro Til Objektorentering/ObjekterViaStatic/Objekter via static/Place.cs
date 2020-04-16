using System;
using System.Collections.Generic;
using System.Text;

namespace Objekter_via_static
{
    class Place
    {
        public static int spaces;
        public string PlaceName { get; private set; }
        public string Muncipality { get; private set; }
        public string Region { get; private set; }


        public Place(string placeName, string muncipality, string region)
        {
            PlaceName = placeName;
            Muncipality = muncipality;
            Region = region;
        }
        public void ShowPLace(int spaces)
        {
            TextDivider(spaces);
            ShowLableandValue("Navn", spaces, PlaceName);
            ShowLableandValue("Kommune", spaces, Muncipality);
            ShowLableandValue("Fylke", spaces, Region);
            TextDivider(spaces);
        }

        private static void ShowLableandValue(string Label, int Spaces, string Value)
        {
            Spaces -= Label.Length;
            Console.WriteLine(Label + " :  ".PadLeft(Spaces, ' ') + Value);
        }

        private static void TextDivider(int spaces)
        {
            spaces += 20;
            Console.WriteLine(string.Empty.PadLeft(spaces, '_'));
        }
    }
}
