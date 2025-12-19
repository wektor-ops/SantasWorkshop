using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public class StandardGift: BaseGift
    {
        private string _wrappingPaperColor;
        private bool _hasBow;
        public string WrappingPaperColor
        {
            get { return _wrappingPaperColor; }
            set { _wrappingPaperColor = value; }
        }

        public bool HasBow
        {
            get { return _hasBow; }
            set { _hasBow = value; }
        }
        public override bool IsReady()
        {
            if (WrappingPaperColor != "")
                return true;
            return false;
        }

        public StandardGift(string name, string description, int weight, bool hasBow = false) : base(name, description, weight)
        {
            
            WrappingPaperColor = "";
            HasBow = hasBow;
        }
    }
}
