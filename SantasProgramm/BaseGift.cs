using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public abstract class BaseGift
    {
        private string _name;
        private string _description;
        private int _weight;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        // Methode damit jedes Geschenk ein Check hat ob es bereit ist
        public virtual bool IsReady()
        {
            if(Name != "")
                return true;
            return false;
        }

        // Konstruktor für die Verkettung von den Erbernden Klassen Konstruktoren damit DRY eingehaten wird
        public BaseGift(string name, string description, int weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }
    }
}
