using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLaag.Enums;

namespace DataLaag.Interfaces
{
    public interface IFWedstrijden
    {
        int wedstrijd_ID { get; set; }
        string thuisPloeg { get; set; }
        string uitPloeg { get; set; }
        int score_ThuisPloeg { get; set; }
        int score_UitPloeg { get; set; }
        Gokken GetWinnaar();
    }
}
