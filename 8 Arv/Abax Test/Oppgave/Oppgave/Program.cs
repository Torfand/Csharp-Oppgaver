using System;

namespace Oppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("MORRADI", 200, 147, TransportType.LightVehicle, "Blue");
            car1.Print();
            var car2 = new Car("Jens", 300, 190, TransportType.LightVehicle, "Green");
            car2.Print();
            car1.Compare(car2, "Car 1 And Car 2 ");
            car1.Drive();
            var plane1 =  new Plane("LA8PV", 1000, 2568, TransportType.Jet, 150 , 300, 90 );
            var plane2 = new Plane("LA8PV", 1000, 2568, TransportType.Jet, 150, 300, 90);
            plane1.Compare(plane2, "Plane 1 And Plane 2");
            plane1.StartPlane();
            var boat = new Boat("Jensimagan" , 50, 10, TransportType.Boat, 500);
            boat.Print();
        }
    }
}
