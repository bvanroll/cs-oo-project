using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        private Dictionary<int, Persoon> personenMetId;
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
            using (StreamReader file = File.OpenText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName+"/DataLaag/Gegevens/Personen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                personen = (List<Persoon>)serializer.Deserialize(file, typeof(List<Persoon>));

            }
            using (StreamReader file = File.OpenText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/DataLaag/Gegevens/Wedstrijden.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                wedstrijden = (List<Wedstrijden>)serializer.Deserialize(file, typeof(List<Wedstrijden>));
            }
            using (StreamReader file = File.OpenText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/DataLaag/Gegevens/Keuzes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                keuzes = (List<Keuze>)serializer.Deserialize(file, typeof(List<Keuze>));
            }
            wedstrijden = (wedstrijden == null) ? new List<Wedstrijden>() : wedstrijden;
            personen = (personen == null) ? new List<Persoon>() : personen;
            keuzes = (keuzes == null) ? new List<Keuze>() : keuzes;
            FixDictonary();

        }
        public void Serialize()
        {
            using (StreamWriter file = File.CreateText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/DataLaag/Gegevens/Keuzes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, keuzes);
            }
            using (StreamWriter file = File.CreateText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/DataLaag/Gegevens/Personen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, personen);
            }
            using (StreamWriter file = File.CreateText(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/DataLaag/Gegevens/Wedstrijden.json"))
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
                p = new Persoon(personen[personen.Count - 1].persoonID + 1, voornaam, naam, adres, gsm, 0);
            }
            catch
            {
                p = new Persoon(0, voornaam, naam, adres, gsm, 0);
                Debug.WriteLine("probleem met id settings");
            }          
            personen.Add(p);
            FixDictonary();
        }

        private void FixDictonary()
        {
            
            personenMetId = new Dictionary<int, Persoon>();
            personenMetId.Clear();
            foreach (Persoon p in personen)
            {
                personenMetId.Add(p.persoonID, p);
            }
        }
        public void MaakVoorbeelden()
        {
            personen.Add(new Persoon(1, "john", "doe", "street", "048765656565", 0.15));
            wedstrijden.Add(new Wedstrijden(128, "belgie", "polen", 1, 0, 2.3, 3, 1.8));
            keuzes.Add(new Keuze(128, 1, 0.15, Gokken.Thuisploeg));
            FixDictonary();
        }

        public List<string> GetGebruikers()
        {
            List<string> lijst = new List<string>();
            if (personen != null) { 
                foreach(Persoon p in personen)
                {
                    lijst.Add(p.persoonID+":"+p.naam + " " + p.voorNaam);
                }
            }
            else
            {
                lijst.Add("None");
            }
            return lijst;
        }
        public List<string> GetWedstrijden()
        {
            List<string> temp = new List<string>();
            if (personen != null)
            {
                foreach (Wedstrijden w in wedstrijden)
                {
                    temp.Add(w.thuisPloeg + " - " + w.uitPloeg);
                }
            }
            else
            {
                temp.Add("None");
            }
            return temp;
        }
        public List<string> GetGeldVerdubbeling(int ID)
        {
            List<string> lijst2 = new List<string>();
            if (personen != null)
            {
                foreach (Wedstrijden a in wedstrijden)
                {
                    if(a.wedstrijdID == ID)
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
        public int[] GetPersoonID()
        {
            return personenMetId.Keys.ToArray();
        }
        public int[] GetWedstrijdID()
        {
            int[] wedstrijdID = new int[wedstrijden.Count];
            int teller = 0;
            foreach (Wedstrijden w in wedstrijden)
            {
                wedstrijdID[teller] = w.wedstrijdID;
                teller++;
            }
            return wedstrijdID;
        }
        private Wedstrijden GetWedstrijd(int ID)
        {
            foreach(Wedstrijden w in wedstrijden)
            {
                if(w.wedstrijdID == ID)
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
                if(k.spelerID == ID)
                {
                    Gokken g = k.gok;
                    double temp = k.inzet;
                    Wedstrijden w = GetWedstrijd(k.matchID);
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

        private Persoon GetPersoon(int id)
        {
            return personenMetId[id];
        }

        public void ClonePersoon(int id)
        {
            try
            {
                Persoon clone = GetPersoon(id);
                
                int [] lijst = GetPersoonID();
                int fixedID = lijst.Max()+1;
                //clone.persoonID = fixedID;
                Persoon test = new Persoon(clone);
                test.persoonID = fixedID;
                personen.Add(new Persoon(test));
                FixDictonary();

            }
            catch(Exception e)
            {
                //throw new Exception("Persoon kon niet gevonden worden met id, desync van de getId lijst op ui");
                
            }
        }


        public void ClearList()
        {
            wedstrijden = new List<Wedstrijden>();
            personen = new List<Persoon>();
            keuzes = new List<Keuze>();
        }
    }
}
