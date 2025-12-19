using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public class Workshop
    {
        private IDeliveryStrategy _deliveryStrategy;
        public IDeliveryStrategy DeliveryStrategy
        {  get { return _deliveryStrategy; }
           set { _deliveryStrategy = value; }
        }

        public Workshop(IDeliveryStrategy deliveryStrategy)
        {
            DeliveryStrategy = deliveryStrategy;
        }

        public static List<BaseGift> AllGifts = new List<BaseGift>();
        public List<Elf> AllElfs = new List<Elf>();

        public void PrepareAndShip(string destination)
        {

            foreach (BaseGift gift in AllGifts)
            {
                    Console.WriteLine($"Geschenk {gift.Name}: wird Versendet");
            }
            _deliveryStrategy.Deliver(destination);
        }
    }
}
