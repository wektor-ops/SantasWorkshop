using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    internal class FragileGift : BaseGift
    {
        private string _protectionMaterial;
        private bool _isPadded;
        public string ProtectionMaterial
        {
            get { return _protectionMaterial; }
            set { _protectionMaterial = value; }
        }

        public bool IsPadded
        {
            get { return _isPadded; }
            set { _isPadded = value; }
        }

        public override bool IsReady()
        {
            return IsPadded;
        }

        // Konstruktor mit VErkettung damit DRY eingehalten wird
        public FragileGift(string name, string description, int weight, string protectionMaterial) : base(name, description, weight) 
        {
            ProtectionMaterial = protectionMaterial;
            IsPadded = false;
        }

    }
}
