using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.General;

namespace Logic
{
    public class Keuze
    {
        
        public int Match_ID { get; set; }
        public int Speler_ID { get; set; }
        public double Inzet { get; set; }
        public Gokken Gok { get; set; } // thuis uit of gelijk
        
    }
}
