using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public interface IDeliveryStrategy
    {
        // Deliver Methode damit jeder Lieferungsart eine Versand möglichkeit hat
        void Deliver(string destination);
    }
}
