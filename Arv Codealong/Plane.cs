using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Codealong
{
    internal class Plane : Vehicle
    {
        public int WingWidth;
        public int CargoLimit;
        public int Weight;
        public string Model;

        

        public Plane(string regNr, int watt, int wingWidth, int cargoLimit, int weight, string model) :base(regNr, watt)
        {

            WingWidth = wingWidth;
            CargoLimit = cargoLimit;
            Weight = weight;
            Model = model;
        }
            
        

        public void PlaneInfo()
        {
            Console.WriteLine($"Plane: {RegNr}, Watt: {Watt}, Wingspan: {WingWidth} Cargo Limit: {CargoLimit}, Weight: {Weight}, Model: {Model}");
        }
    }
}
