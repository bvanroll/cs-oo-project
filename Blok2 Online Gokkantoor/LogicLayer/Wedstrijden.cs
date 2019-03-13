using DataLaag.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static DataLaag.Enums;

namespace LogicLayer
{
    public class Wedstrijden : IFWedstrijden
    {
        public int wedstrijdID { get; set; }
        public string thuisPloeg { get; set; }
        public string uitPloeg { get; set; }
        public int scoreThuisPloeg { get; set; }
        public int scoreUitPloeg { get; set; }
        public double geldThuisPloeg { get; set; }
        public double geldGelijk { get; set; }
        public double geldUitPloeg { get; set; }


        [JsonConstructor]
        public Wedstrijden(int wedstrijdID, string thuisPloeg, string uitPloeg, int scoreThuisPloeg, int scoreUitPloeg, double geldThuisPloeg, double geldGelijk, double geldUitPloeg)
        {
            string varNaam = "", data = "", error = $"Probleem bij het invoeren van {varNaam} met de waarde {data}";
            try
            {
                this.wedstrijdID = wedstrijdID;
            }
            catch (Exception e)
            {
                varNaam = "wedstrijdID";
                data = wedstrijdID + "";
                throw new Exception(error);
            }
            try
            {
                this.thuisPloeg = thuisPloeg;
            }
            catch (Exception e)
            {
                varNaam = "thuisPloeg";
                data = thuisPloeg + "";
                throw new Exception(error);
            }
            try
            {
                this.uitPloeg = uitPloeg;
            }
            catch (Exception e)
            {
                varNaam = "uitPloeg";
                data = uitPloeg + "";
                throw new Exception(error);
            }
            try
            {
                this.scoreThuisPloeg = scoreThuisPloeg;
            }
            catch (Exception e)
            {
                varNaam = "scoreThuisPloeg";
                data = scoreThuisPloeg + "";
                throw new Exception(error);
            }
            try
            {
                this.scoreUitPloeg = scoreUitPloeg;
            }
            catch (Exception e)
            {
                varNaam = "scoreUitPloeg";
                data = scoreUitPloeg + "";
                throw new Exception(error);
            }
            try
            {
                this.geldThuisPloeg = geldThuisPloeg;
            }
            catch (Exception e)
            {
                varNaam = "geldThuisPloeg";
                data = geldThuisPloeg + "";
                throw new Exception(error);
            }
            try
            {
                this.geldGelijk = geldGelijk;
            }
            catch (Exception e)
            {
                varNaam = "geldGelijk";
                data = geldGelijk + "";
                throw new Exception(error);
            }
            try
            {
                this.geldUitPloeg = geldUitPloeg;
            }
            catch (Exception e)
            {
                varNaam = "geldUitPloeg";
                data = geldUitPloeg + "";
                throw new Exception(error);
            }
        }

        public Gokken GetWinnaar()
        {
            if(scoreThuisPloeg > scoreUitPloeg)
            {
                return Gokken.Thuisploeg;
            }else if(scoreUitPloeg > scoreThuisPloeg)
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
