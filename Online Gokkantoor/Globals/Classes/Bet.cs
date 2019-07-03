using System;
using Globals.Interfaces;

namespace Globals.classes
{
    public class Bet : IBet
    {
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
        public bool succes { get { return (ploeg == game.getWinner());}}
        public main.state ploeg { get; set; }
        public bool finished { get; set; }

        public override bool Equals(object obj)
        {
            Bet b = (Bet)obj;
            return b.game == this.game && this.person == b.person && b.cash == this.cash && this.ploeg == b.ploeg;
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
                if (succes)
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
            return person.ToString() + ":" + this.cash + "$ on " + this.game.ToString();
        }
    }
}
