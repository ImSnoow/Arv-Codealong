using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Codealong
{
    internal class Vehicle
    {
        public string RegNr;
        public int Watt;

        public Vehicle(string regNr, int watt)
        {
            RegNr = regNr;
            Watt = watt;

        }


        public void Drive()
        {
            Console.WriteLine(RegNr + " Kjører.");
        }
    }
}
