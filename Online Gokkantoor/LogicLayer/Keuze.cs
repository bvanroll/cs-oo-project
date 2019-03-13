using DataLaag.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLaag.Enums;

namespace LogicLayer
{
    public class Keuze : IFKeuze
    {
        
        public int match_ID { get; set; }
        public int speler_ID { get; set; }
        public double inzet { get; set; }
        public Gokken gok { get; set; } // thuis uit of gelijk

        public Keuze(int match_ID, int speler_ID, double inzet, Gokken gok)
        {
            try
            {
                this.match_ID = match_ID;
                this.speler_ID = speler_ID;
                this.inzet = inzet;
                this.gok = gok;

            } catch (Exception e)
            {
                throw new Exception("keuze is niet gelukt:" + e);
            }
        }
    }
}

