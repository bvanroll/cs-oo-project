using System;
using Globals.Interfaces;

namespace Globals.classes
{
    public class Ploeg : IPloeg
    {
        public Ploeg(string naam)
        {
            this.naam = naam;
            this.score = int.MinValue;
            
        }

        public Ploeg(string naam, int score) : this(naam)
        {
            this.score = score;
        }

        public int Id { get; set; }
        public string naam { get; set; }
        public int score { get; set; }
        public bool scoreSet { get => this.score != int.MinValue; }
        
        public override bool Equals(object obj)
        {
            Ploeg t = (Ploeg)obj;
            return this.Id == t.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string score = "";
            if (this.score != int.MinValue)
            {
                score = ":" + this.score;
            }
            return this.naam + score;
        }

    }
}
