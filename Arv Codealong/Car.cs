using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Codealong
{
    internal class Car : Vehicle
    {
        public int TopSpeed;
        public string Color;
        public string WeightClass;

        public Car(string regNr, int watt, int topSpeed, string color, string weightClass) : base(regNr, watt)
        {
            TopSpeed = topSpeed;
            Color = color;
            WeightClass = weightClass;
        }


        public void CarInfo()
        {
            Console.WriteLine($"Car: {RegNr}, Watt: {Watt}, TopSpeed: {TopSpeed}, Color: {Color}, WeightClass: {WeightClass}");
        }
    }
}
