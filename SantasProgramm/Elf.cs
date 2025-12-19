using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SantasProgramm
{
    public class Elf
    {
        private string _name;
        private string _task;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Task
        {
            get { return _task; }
            set { _task = value; }
        }

        public Elf(string name, string task)
        {
            _name = name;
            _task = task;
        }
        public void Work()
        {
                Console.WriteLine($"{Name} arbeitet an der Aufgabe: {Task}.");
        }
        public void GiveNewTask(string task)
        {
            Task = task;
        }
        // 3 Überladungen für MakeGift damit die einzelnen Geschenke der verschiedenen Typen erstellt werden können ohne immer einen anderen Namen zu schreiben. 
        public void MakeGift(string name, string description, int weight, bool hasBow, string wrappingPaperColor)
        {
            Console.WriteLine($"{Name} erstellt ein {description}.");
            Workshop.AllGifts.Add(new StandardGift(name, description, weight, hasBow));
            if (Workshop.AllGifts.Find(g => g.Name == name) is StandardGift standardGift)
            {
                Console.WriteLine($"{Name} verpackt das Gechenk in Papier der Farbe {wrappingPaperColor}.");
                standardGift.WrappingPaperColor = wrappingPaperColor;
            }
        }
        public void MakeGift(string name, string description, int weight, string protectionMaterial)
        {
            Console.WriteLine($"{Name} erstellt ein {description}.");
            Workshop.AllGifts.Add(new FragileGift(name, description, weight, protectionMaterial));
            if (Workshop.AllGifts.Find(g => g.Name == name) is FragileGift fragileGift)
            {
                Console.WriteLine($"{Name} verpackt das Gechenk in Schutzmaterial {protectionMaterial}.");
                fragileGift.ProtectionMaterial = protectionMaterial;
            }
        }
        public void MakeGift(string name, string description, int weight, bool needsBatteries)
        {
            Console.WriteLine($"{Name} erstellt ein {description}.");
            Workshop.AllGifts.Add(new ElectronicGift(name, description, weight, needsBatteries));
            if (Workshop.AllGifts.Find(g => g.Name == name) is ElectronicGift electronicGift)
            {
                if (electronicGift.NeedsBatteries)
                {
                    Console.WriteLine($"{Name} verpackt das Gechenk mit Batterien.");
                    electronicGift.AreBatteriesIncluded = true;
                }
                Console.WriteLine($"{Name} verpackt das Gechenk.");
            }
        }
    }
}
