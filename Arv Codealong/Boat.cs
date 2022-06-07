using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Wallah brur. fet bmw
/// </summary>
namespace Arv_Codealong
{
    internal class Boat : Vehicle

    {
        public int TopSpeed;
        public int Weight;

        public Boat(string regNr, int watt, int topSpeed, int weight) : base(regNr, watt)
        {
            TopSpeed = topSpeed;
            Weight = weight;
        }
            
        public void BoatInfo()
        {
            Console.WriteLine($"Boat: {RegNr}, Watt: {Watt}, TopSpeed: {TopSpeed}, Weight: {Weight}");
                                        
        }
    }
    
}
