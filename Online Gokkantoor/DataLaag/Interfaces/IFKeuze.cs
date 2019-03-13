using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLaag.Enums;

namespace DataLaag.Interfaces
{
    public interface IFKeuze 
    {
        int match_ID { get; set; }
        int speler_ID { get; set; }
        double inzet { get; set; }
        Gokken gok { get; set; }
    }
}
