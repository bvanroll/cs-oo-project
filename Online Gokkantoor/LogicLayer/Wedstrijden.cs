using DataLaag.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static DataLaag.Enums;

namespace LogicLayer
{
    public class Wedstrijden : IFWedstrijden
    {
        public int wedstrijd_ID { get; set; }
        public string thuisPloeg { get; set; }
        public string uitPloeg { get; set; }
        public int score_ThuisPloeg { get; set; }
        public int score_UitPloeg { get; set; }
        public double geldThuisPloeg { get; set; }
        public double geldGelijk { get; set; }
        public double geldUitPloeg { get; set; }


        public Wedstrijden(int wedstrijd_ID, string thuisPloeg, string uitPloeg, int score_ThuisPloeg, int score_UitPloeg, double geldThuisPloeg, double geldGelijk, double geldUitPloeg)
        {
            this.wedstrijd_ID = wedstrijd_ID;
            this.thuisPloeg = thuisPloeg;
            this.uitPloeg = uitPloeg;
            this.score_ThuisPloeg = score_ThuisPloeg;
            this.score_UitPloeg = score_UitPloeg;
            this.geldThuisPloeg = geldThuisPloeg;
            this.geldGelijk = geldGelijk;
            this.geldUitPloeg = geldUitPloeg;
        }

        public Gokken GetWinnaar()
        {
            if(score_ThuisPloeg > score_UitPloeg)
            {
                return Gokken.Thuisploeg;
            }else if(score_UitPloeg > score_ThuisPloeg)
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
