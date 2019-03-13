using DataLaag.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLaag.Enums;

namespace LogicLayer
{
    public class Keuze : IFKeuze
    {
        
        public int matchID { get; set; }
        public int spelerID { get; set; }
        public double inzet { get; set; }
        public Gokken gok { get; set; } // thuis uit of gelijk

        [JsonConstructor]
        public Keuze(int matchID, int spelerID, double inzet, Gokken gok)
        {
            string naam = "";
            string data = "";
            string varNaam = $"Probleem bij het ingeven van {naam} met waarde {data}";
            try
            {
                this.matchID = matchID;

            } catch (Exception e)
            {
                naam = "matchID";
                data = matchID + "";
                throw new Exception(varNaam);
            }
            try
            {
                this.spelerID = spelerID;

            }
            catch (Exception e)
            {
                naam = "spelerID";
                data = spelerID + "";
                throw new Exception(varNaam);
            }
            try
            {
                this.inzet = inzet;

            }
            catch (Exception e)
            {
                naam = "inzet";
                data = inzet + "";
                throw new Exception(varNaam);
            }
            try
            {
                this.gok = gok;

            }
            catch (Exception e)
            {
                naam = "gok";
                data = gok + "";
                throw new Exception(varNaam);
            }
        }
        public Keuze(Keuze keuze)
        {
            this.gok = keuze.gok;
            this.inzet = keuze.inzet;
            this.matchID = keuze.matchID;
            this.spelerID = keuze.spelerID;
        }
    }


}

