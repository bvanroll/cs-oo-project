using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLaag.Interfaces
{
    public interface IFPersoon
    {
        int persoon_ID { get; set; }
        string voorNaam { get; set; }
        string naam { get; set; }
        string adres { get; set; }
        string gsm { get; set; }
        double balans { get; set; }
    }
}
