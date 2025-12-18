using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    internal class DroneDelivery: IDeliveryStrategy
    {
        private int _rotorCount;
        public int RotorCount
        {
            get { return _rotorCount; }
            set { _rotorCount = value; }
        }

        public DroneDelivery(int rotorCount = 4) 
        { 
            RotorCount = rotorCount;
        }

        public void Deliver(string destination)
        {
            Console.WriteLine($"Drone nach {destination} gestartet.");
        }
    }
}
