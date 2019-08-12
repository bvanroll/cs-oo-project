using Globals.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.classes
{
    public class PloegInMatch : Ploeg
    {
        public PloegInMatch(int id, string naam) : base(id, naam)
        {
        }

        public PloegInMatch(int id, string naam, int score) : base(id, naam)
        {
            setScore(score);
        }

        public PloegInMatch(Ploeg p) : base(p)
        {
            this.Id = p.Id;
            this.naam = p.naam;

        }


        public PloegInMatch(Ploeg p, int score) : base(p)
        {
            this.Id = p.Id;
            this.naam = p.naam;
            setScore(score);

        }

        public int score { get; private set; }
        public bool scoreSet { get; private set; }
        public event EventHandler scoreChanged;

        public void setScore(int score)
        {
            EventHandler h = scoreChanged;
            if (null != h) h(this, EventArgs.Empty);
            this.score = score;
            this.scoreSet = true;
        }


    }
}
