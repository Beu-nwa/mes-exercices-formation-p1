using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_a_tester
{
    public class Annee
    {
        private int a { get; set; }
        public Annee(int n)
        {
            a = n;
        }

        public bool IsBissextile()
        {
            return ( (a % 400 == 0 && a % 4000 != 0 ) || (a % 4 == 0 && a % 100 != 0) );
        }
    }
}
