using SantasProgramm;

IDeliveryStrategy deliveryStrategy = new SleighDelivery();
Workshop santasWorkshop = new Workshop(deliveryStrategy);

santasWorkshop.AllGifts.Add(new ElectronicGift(
            "Gaming PC", "Computer für Videospiele", 12, true, true));

santasWorkshop.AllGifts.Add(new FragileGift(
            "Vase", "Antike Glasvase", 3, "Luftpolsterfolie", true));

santasWorkshop.AllGifts.Add(new StandardGift(
            "Teddybär", "Kuscheliges Stofftier", 1, "Blaues Papier", true));

santasWorkshop.PrepareAndShip("Sursee");

Console.ReadKey();