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
        int wedstrijdID { get; set; }
        string thuisPloeg { get; set; }
        string uitPloeg { get; set; }
        int scoreThuisPloeg { get; set; }
        int scoreUitPloeg { get; set; }
        Gokken GetWinnaar();
    }
}
