using System;
using Globals.Interfaces;
using Newtonsoft.Json;
using static Globals.main;

namespace Globals.classes
{
    public class Bet : IBet
    {
        [JsonConstructor]
        public Bet(int Id, Game g, Person p, double cash, state ploeg, bool finished)
        {
            this.Id = Id;
            this.game = g;
            this.person = p;
            this.cash = cash;
            this.ploeg = ploeg;
            this.finished = finished;

        }
        public Bet(Game game, Person person, double cash, main.state ploeg)
        {
            this.game = game;
            this.person = person;
            this.cash = cash;
            this.ploeg = ploeg;
            this.finished = false;
        }
        public int Id { get; set; }
        public Game game { get; set; }
        public Person person { get; set; }
        public double cash { get; set; }
        public main.state ploeg { get; set; }
        public bool finished { get; set; }


        public bool succes()
        {
            return (ploeg == game.getWinner());
        }
        public override bool Equals(object obj)
        {
            try
            {
                Bet be = (Bet)obj;

            } catch (Exception e)
            {
                return false;
            }

            Bet b = (Bet)obj;
            return this.Id == b.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double getProfit()
        {
            double tmp = 0;
            if (finished)
            {
                if (succes())
                {
                    tmp += cash * 2;
                }
            }
            else
            {
                throw new Exception("GAME NOT FINISHED DUH");
            }
            return tmp;
        }

        public override string ToString()
        {
            return this.Id + ": " + person.ToString() + ":" + this.cash + "$ on " + this.game.ToString();
        }
    }
}
