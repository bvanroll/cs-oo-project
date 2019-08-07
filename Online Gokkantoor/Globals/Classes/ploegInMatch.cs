using Globals.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Classes
{
    public class PloegInMatch : Ploeg
    {
        

        public int score;

        public PloegInMatch(int score)
        {
            this.score = score;
        }

        public override zegMijnNaam(string naam)
        {
            return "blabla " + naam;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
