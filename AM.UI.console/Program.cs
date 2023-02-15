using AM.ApplicationCore.Domain;
using System;

namespace AM.UI.console
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Plane p1 = new Plane();

            p1.Capacity = 200;
            p1.ManufactureDate = new DateTime(2015, 01, 16);
            p1.PlaneType = PlaneType.Boing;
            p1.PlaneId = 2;

            Console.WriteLine(p1);


            Plane p3 = new Plane
            {
                PlaneType = PlaneType.Airbus,
                Capacity = 150,
                ManufactureDate = new DateTime(2015, 02, 03)
            };
            Console.WriteLine(p3);
            Passenger passenger = new Passenger();
            passenger.PassengerType();
            Staff staff = new Staff();
            staff.PassengerType();
            Travelier travelier = new Travelier();
            travelier.PassengerType();



        }


    }
}