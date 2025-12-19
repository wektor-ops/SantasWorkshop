using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public class SleighDelivery: IDeliveryStrategy
    {
        private int _reindeerCount;
        public int ReindeerCount
        {
            get { return _reindeerCount; }
            set { _reindeerCount = value; }
        }

        public SleighDelivery(int reindeerCount = 6)
        {
            ReindeerCount = reindeerCount;
        }
        // Deliver Methode damit Interface eingehalten wird
        public void Deliver(string destination)
        {
            Console.WriteLine($"Schlitten nach {destination} gestartet.");
        }
    }
}
