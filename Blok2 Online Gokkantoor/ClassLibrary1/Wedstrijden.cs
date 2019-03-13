using System;
using System.Collections.Generic;
using System.Text;
using static Logic.General;

namespace Logic
{
    public class Wedstrijden
    {
        public int Wedstrijd_ID { get; set; }
        public string ThuisPloeg { get; set; }
        public string UitPloeg { get; set; }
        public int Score_ThuisPloeg { get; set; }
        public int Score_UitPloeg { get; set; }

        public Gokken Winnaar()
        {
            if(Score_ThuisPloeg > Score_UitPloeg)
            {
                return Gokken.ThuisPloeg;
            }else if(Score_UitPloeg > Score_ThuisPloeg)
            {
                return Gokken.Uitploeg;
            }
            else
            {
                return Gokken.Gelijk;
            }
        }

    }
}
