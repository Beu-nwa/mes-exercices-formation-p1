using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__pendu.Classes
{
    internal class LePendu
    {

        public int NbEssai { get; set; }
        public string Masque { get; set; }
        public string MotATrouve { get; set; }
        public LePendu()
        {
            NbEssai = 0;
            Masque = "";
            MotATrouve = "";
        }

    }
}
