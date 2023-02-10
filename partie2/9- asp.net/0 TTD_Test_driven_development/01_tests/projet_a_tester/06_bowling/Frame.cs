using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_a_tester._06_bowling
{
    public class Frame
    {
        private int score;
        private bool _lastFrame;
        private IGenerateur _generateur;
        private List<Roll> rolls;

        public Frame(IGenerateur generateur, bool lastFrame)
        {
            _lastFrame = lastFrame;
            _generateur = generateur;
        }
        public bool MakeRoll()
        {


            return _generateur.RandomPin(10) == 10; // strike
        }
    }
}
