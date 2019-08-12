using System;
using Globals.Interfaces;
using Newtonsoft.Json;

namespace Globals.classes
{
    public class Ploeg : IPloeg
    {
        [JsonConstructor]
        public Ploeg(int Id, string naam, int score)
        {
            this.Id = Id;
            this.naam = naam;
            this.score = score;
        }

        public Ploeg(string naam)
        {
            this.naam = naam;
            this.score = int.MinValue;
            
        }

        public Ploeg(string naam, int score) : this(naam)
        {
            this.score = score;
        }
        public Ploeg(string naam, int score, int Id)
        {
            this.score = score;
            this.naam = naam;
            this.Id = Id;
        }

        public int Id { get; set; }
        public string naam { get; set; }
        public int score { get; private set; }
        public bool scoreSet { get; }

        public event EventHandler scoreChanged;

        public override bool Equals(object obj)
        {
            try
            {
                Ploeg te = (Ploeg)obj;

            } catch (Exception e)
            {
                return false;
            }
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
            return this.Id + ": " + this.naam + score;
        }

        public void setScore(int i)
        {
            EventHandler h = scoreChanged;
            if (null != h) h(this, EventArgs.Empty);
            this.score = i;
        }
        public int getScore()
        {
            return this.score;
        }
    }
}
