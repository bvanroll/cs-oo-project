using DataLaag.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
    public class Persoon : IFPersoon
    {
        public int persoon_ID { get; set; }
        public string voorNaam { get; set; }
        public string naam { get; set; }
        public string adres { get; set; }
        public string gsm { get; set; }
        public double balans { get; set; }


        public Persoon(int persoon_ID, string voorNaam, string naam, string adres, string gsm, double balans)
        {
            try
            {
                this.persoon_ID = persoon_ID;
                this.voorNaam = voorNaam;
                this.naam = naam;
                this.adres = adres;
                this.gsm = gsm;
                this.balans = balans;
            }
            catch (Exception ex)
            {
                throw new Exception("Foutieve ingave: " + ex);
            }
        }
    }
}
    


