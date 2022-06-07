using System;
using System.Collections.Generic;

namespace Arv_Codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("NF123456", 147, 200, "Grønn", "lett kjøretøy");
            car1.CarInfo();

            var car2 = new Car("NF654321", 150, 195, "blå", "lett kjøretøy");
            car2.CarInfo();

            var plane1 = new Plane("LN1234", 1000, 30, 2, 10, "Jetfly");
            plane1.PlaneInfo();

            var boat1 = new Boat("ABC123", 100, 30, 500);
            boat1.BoatInfo();

            bool isUnique = true;
            if (car1.RegNr == car2.RegNr)
            {
                isUnique = false;
                Console.WriteLine("Bilene er like");
            }
            else
            {
                Console.WriteLine("Bilene er ulike");
            }
            
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car1);
            vehicles.Add(plane1);
            vehicles.Add(boat1);

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }

            Console.ReadKey();
        }
    }
}
