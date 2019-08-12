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
        public int Id;
        public PloegInMatch(int id, string naam) : base( naam)
        {
            this.Id = id;
        }

        public PloegInMatch(int id, string naam, int score) : base(naam)
        {
            this.Id = id;
            setScore(score);
        }

        public PloegInMatch(Ploeg p, int id) : base(p)
        {
            this.Id = id;
            this.naam = p.naam;

        }


        public PloegInMatch(Ploeg p, int score, int id) : base(p)
        {
            this.Id = id;
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            if (this.scoreSet) return this.naam + ": " +this.score;
            else return this.naam + ": NaN";

        }
    }
}
