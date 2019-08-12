using System;
using Globals.Interfaces;
using Newtonsoft.Json;

namespace Globals.classes
{
    public class Ploeg : IPloeg
    {
        public Ploeg(int id, string naam)
        {
            Id = id;
            this.naam = naam;
        }

        public Ploeg(Ploeg p)
        {
            this.Id = p.Id;
            this.naam = p.naam;
        }
        public int Id { get; set; }
        public string naam { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return this.naam;
        }
    }
}
