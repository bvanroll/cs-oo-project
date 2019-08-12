using System;
using Globals.Interfaces;
using Newtonsoft.Json;

namespace Globals.classes
{
    public class Ploeg : IPloeg
    {
        public Ploeg(string naam)
        {
            this.naam = naam;
        }

        public Ploeg(Ploeg p)
        {
            this.naam = p.naam;
        }
        public string naam { get; set; }

        public override bool Equals(object obj)
        {
            return ((Ploeg)obj).naam == this.naam;
        }

        public override string ToString()
        {
            return this.naam;
        }
    }
}
