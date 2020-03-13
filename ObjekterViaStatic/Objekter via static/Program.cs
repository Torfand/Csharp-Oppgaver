using System;

namespace Objekter_via_static
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaces =11;
            var Place = new  Place("Sandefjord" , "Coronaland 3000", "Vestfold");
     
            Place.ShowPLace(spaces);

            var place2  = new Place("Stokke", "DerKorIngenKunneTru", "Vestfold");
           
            place2.ShowPLace(spaces);

        }

        
    }
}
