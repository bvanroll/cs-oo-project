using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DataLaag;
using DataLaag.Interfaces;
using Newtonsoft.Json;
using static DataLaag.Enums;

namespace LogicLayer
{
    public class General
    {
        public List<Wedstrijden> wedstrijden { get; set; }
        public List<Persoon> personen { get; set; }
        public List<Keuze> keuzes { get; set; }

        public General()
        {
            wedstrijden = new List<Wedstrijden>();
            try
            {
                personen = new List<Persoon>();
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
            try
            {
                keuzes = new List<Keuze>();
            }catch (Exception e)
            {
                throw new Exception("" + e);
            } 
                Deserialize();        
        }

        public void Deserialize()
        {
            using (StreamReader file = File.OpenText(@"Gegevens\Keuzes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                keuzes = (List<Keuze>)serializer.Deserialize(file, typeof(List<Keuze>));

            }
            using (StreamReader file = File.OpenText(@"Gegevens\Personen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                personen = (List<Persoon>)serializer.Deserialize(file, typeof(List<Persoon>));
            }
            using (StreamReader file = File.OpenText(@"Gegevens\Wedstrijden.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                wedstrijden = (List<Wedstrijden>)serializer.Deserialize(file, typeof(List<Wedstrijden>));
            }
            wedstrijden = (wedstrijden == null) ? new List<Wedstrijden>() : wedstrijden;
            personen = (personen == null) ? new List<Persoon>() : personen;
            keuzes = (keuzes == null) ? new List<Keuze>() : keuzes;

        }
        public void Serialize()
        {
            using (StreamWriter file = File.CreateText(@"Gegevens\Keuzes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, keuzes);
            }
            using (StreamWriter file = File.CreateText(@"Gegevens\Personen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, personen);
            }
            using (StreamWriter file = File.CreateText(@"Gegevens\Wedstrijden.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, wedstrijden);
            }
        }

        public void PlaatsGok(int matchID, int persoonID, double inzet, string g)
        {
            try
            {
                Enum.TryParse(g, out Gokken gok);
                Keuze k = new Keuze(matchID, persoonID, inzet, gok);
                keuzes.Add(k);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public void GebruikerToevoegen(string voornaam, string naam, string adres, string gsm)
        {
            Persoon p = new Persoon(0, "Voornaam", "Naam", "Adres", "Gsm", 0.00);
            try
            {
                p = new Persoon(personen[personen.Count - 1].persoon_ID + 1, voornaam, naam, adres, gsm, 0);
            }
            catch
            {
                p = new Persoon(0, voornaam, naam, adres, gsm, 0);
                Debug.WriteLine("probleem met id settings");
            }          
            personen.Add(p);
        }

        public void MaakVoorbeelden()
        {
            personen.Add(new Persoon(1, "john", "doe", "street", "048765656565", 0.15));
            wedstrijden.Add(new Wedstrijden(128, "belgie", "polen", 1, 0, 2.3, 3, 1.8));
            keuzes.Add(new Keuze(128, 1, 0.15, Gokken.Thuisploeg));
        }

        public List<Persoon> GetGebruikers()
        {
            return personen;
        }

        public List<Wedstrijden> GetWedstrijden()
        {
            return wedstrijden;
        }

        public List<string> GetGeldVerdubbeling(int ID)
        {
            List<string> lijst2 = new List<string>();
            if (personen != null)
            {
                foreach (Wedstrijden a in wedstrijden)
                {
                    if(a.wedstrijd_ID == ID)
                    {
                        lijst2.Add(a.geldThuisPloeg + "");
                        lijst2.Add(a.geldGelijk + "");
                        lijst2.Add(a.geldUitPloeg + "");
                    }
                }
            }
            else
            {
                lijst2.Add("None");
                lijst2.Add("None");
                lijst2.Add("None");
            }
            return lijst2;
        }

        public int[] GetP_ID()
        {
            int[] p_ID = new int[personen.Count];
            int teller = 0;
            foreach (Persoon p in personen)
            {
                p_ID[teller] = p.persoon_ID;
                teller++;
            }
            return p_ID;
        }

        public int[] GetW_ID()
        {
            int[] w_ID = new int[wedstrijden.Count];
            int teller = 0;
            foreach (Wedstrijden w in wedstrijden)
            {
                w_ID[teller] = w.wedstrijd_ID;
                teller++;
            }
            return w_ID;
        }

        private Wedstrijden GetWedstrijd(int ID)
        {
            foreach(Wedstrijden w in wedstrijden)
            {
                if(w.wedstrijd_ID == ID)
                {
                    return w;
                }
            }
            return null;
        }

        public double GetWinst(int ID)
        {
            double winst = 0;
            foreach (Keuze k in keuzes)
            {
                if(k.speler_ID == ID)
                {
                    Gokken g = k.gok;
                    double temp = k.inzet;
                    Wedstrijden w = GetWedstrijd(k.match_ID);
                    Gokken uitKomst = w.GetWinnaar();
                    if(uitKomst == g)
                    {
                        switch (uitKomst)
                        {
                            case Gokken.Gelijk:
                                winst += temp * w.geldGelijk;
                                break;
                            case Gokken.Thuisploeg:
                                winst += temp * w.geldThuisPloeg;
                                break;
                            case Gokken.Uitploeg:
                                winst += temp * w.geldUitPloeg;
                                break;
                        }
                    }
                    
                }
            }
            return winst;
        }
    }
}
