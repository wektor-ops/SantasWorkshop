using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    internal class ElectronicGift : BaseGift
    {
        private bool _needsBatteries;
        private bool _areBatteriesIncluded;
        public bool NeedsBatteries
        {
            get { return _needsBatteries; }
            set { _needsBatteries = value; }
        }

        public bool AreBatteriesIncluded
        {
            get { return _areBatteriesIncluded; }
            set { _areBatteriesIncluded = value; }
        }

        public override bool IsReady()
        {
            return !NeedsBatteries || AreBatteriesIncluded;
        }

        public ElectronicGift(string name, string description, int weight, bool needsBatteries) : base(name, description, weight) 
        {
            NeedsBatteries = needsBatteries;
            AreBatteriesIncluded = false;
        }
    }
}
