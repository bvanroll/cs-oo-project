using DataLaag.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
    public class Persoon : IFPersoon
    {
        public int persoonID { get; set; }
        public string voorNaam { get; set; }
        public string naam { get; set; }
        public string adres { get; set; }
        public string gsm { get; set; }
        public double balans { get; set; }

        [JsonConstructor]
        public Persoon(int persoonID, string voorNaam, string naam, string adres, string gsm, double balans)
        {
            string varNaam = "", data = "", er = $"Foutieve ingave: Probleem ingeven {varNaam} controleer syntax van {data}";

            try
            {
                this.persoonID = persoonID;
            }
            catch (Exception ex) {
                varNaam = "persoonID";
                data = persoonID + "";
                throw new Exception($"Foutieve ingave: Probleem aanmaken {varNaam} zie databank voor waarde {data}");
            }
            try
            {
                this.voorNaam = voorNaam;
            }
            catch (Exception ex)
            {
                varNaam = "voorNaam";
                data = voorNaam + "";
                throw new Exception(er);
            }
            try
            {
                this.naam = naam;
            }
            catch (Exception ex)
            {
                varNaam = "naam";
                data = naam + "";
                throw new Exception(er);
            }
            try
            {
                this.adres = adres;
            }
            catch (Exception ex)
            {
                varNaam = "adres";
                data = adres + "";
                throw new Exception(er);
            }
            try
            {
                this.gsm = gsm;
            }
            catch (Exception ex)
            {
                varNaam = "gsm nummer";
                data = gsm + "";
                throw new Exception(er);
            }
            try
            {
                this.balans = balans;
            }
            catch (Exception ex)
            {
                varNaam = "balans";
                data = balans + "";
                throw new Exception($"Foutieve ingave: een probleem bij het setten van de {varNaam} : {data}");
            }
        }
        public Persoon(Persoon persoon)
        {
            persoonID = persoon.persoonID;
            voorNaam = persoon.voorNaam;
            naam = persoon.naam + " BACK UP";
            adres = persoon.adres;
            gsm = persoon.gsm;
            balans = persoon.balans;
        }
    }
}
    


