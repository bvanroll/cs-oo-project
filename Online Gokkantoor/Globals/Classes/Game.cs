using System;
using Globals.Interfaces;
using static Globals.main;

namespace Globals.classes
{
    public class Game : IGame
    {
        public DateTime date { get; set; } //y m d
        public Game(Ploeg home, Ploeg away, DateTime d)
        {
            this.home = home;
            this.away = away;
            this.date = d;
        }
        public Game(Ploeg home, Ploeg away, DateTime d, int scoreHome, int scoreAway)
        {
            this.home = home;
            this.away = away;
            this.home.score = scoreHome;
            this.away.score = scoreAway;
            this.date = d;
        }
        public Game(int id, Ploeg home, Ploeg away)
        {
            Id = id;
            this.home = home ?? throw new ArgumentNullException(nameof(home));
            this.away = away ?? throw new ArgumentNullException(nameof(away));
        }

        public Game(int id, Ploeg home, Ploeg away, int scoreHome, int scoreAway)
        {
            Id = id;
            this.home = home ?? throw new ArgumentNullException(nameof(home));
            this.away = away ?? throw new ArgumentNullException(nameof(away));
            this.home.score = scoreHome;
            this.away.score = scoreAway;
        }

        public int Id { get; set; }
        public Ploeg home { get; set; }
        public Ploeg away { get; set; }








        public state getWinner()
        {
            if (!this.home.scoreSet || !this.away.scoreSet)
            {
                if (this.home.score > this.away.score) return state.home;
                else if (this.away.score > this.home.score) return state.away;
                else return state.draw;
            } else
            {
                throw new Exception("No scores were set yet. Please set scores for the game first.");
            }

        }








        public override bool Equals(object obj)
        {
            Game g = (Game)obj;
            return this.home == g.away;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override string ToString()
        {
            return this.home.ToString() + " / " + this.away.ToString();
        }
    }
}
