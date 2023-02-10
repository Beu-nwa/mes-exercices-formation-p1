using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_a_tester._06_bowling
{
    public class Roll : IGenerateur
    {
        private Random random;

        public Roll()
        {
            random = new Random();
        }

        public int RandomPin(int x)
        {
            return random.Next(0, x);
        }
    }
}
