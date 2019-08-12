using Globals.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class db
    {
        public List<Person> persons { get; set; }
        public List<Bet> bets { get; set; }
        public List<Ploeg> ploegen { get; set; }
        public List<Game> games { get; set; }
        public List<PloegInMatch> ploegInMatches { get; set; }
    }
}
