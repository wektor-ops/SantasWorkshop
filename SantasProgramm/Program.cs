using SantasProgramm;

IDeliveryStrategy deliveryStrategy = new SleighDelivery();
Workshop santasWorkshop = new Workshop(deliveryStrategy);

Elf Khalil = new Elf("Khalil", "");

Khalil.GiveNewTask("Teddy Geschenk Herstellen");
Khalil.Work();
Khalil.MakeGift("Teddybär", "Kuscheliges Stofftier", 1,true,  "Blaues Papier");
santasWorkshop.PrepareAndShip("Sursee");

Console.ReadKey();