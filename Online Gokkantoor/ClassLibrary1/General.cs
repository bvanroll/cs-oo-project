using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class General
    {
        /*
            bijna alle berekeningen voor het prorgamma gaan uit deze klasse komen 
             
             
        */





        /* hier komen de wedstrijden en zo die je inlaad*/
        public List<Wedstrijden> wedstrijden { get; set; }
        public List<Persoon> personen { get; set; }
        public List<Keuze> keuzes { get; set; }
        public enum Gokken { ThuisPloeg, Gelijk, Uitploeg }




        /*
            door gebruik van deze klassen kan je bekijken welk team gewonnen heeft en 
            door gebruik van keuze kan je zien hoeveel de persoon met id x ingezet heeft en zo de winst berekenen.
        */

        public double Winst(int wedstrijdID, int persoonID, int keuzeID)
        {
            return 0.0;
        }

        /*
          deze functie haalt een persoon uit de lijst van personen met de juiste id, best ook mss maken voor een wedstrijd en een keuze, gewoon voor gemak later.
         */
       
        public Persoon GetPersoonById(int id)
        {
            return new Persoon();
        }

        public void OnLoad()
        {
            wedstrijden = Laad_Wedstrijden();
        }
    }
}
