using System;
using Globals.Interfaces;
using Newtonsoft.Json;
using static Globals.main;

namespace Globals.classes
{
    public class Game : IGame
    {

        [JsonConstructor]
        public Game(int Id, PloegInMatch home, PloegInMatch away, DateTime date)
        {
            homeSetBool = false;
            awaySetBool = false;

            this.Id = Id;
            this.home = home;
            this.away = away;
            this.home.scoreChanged += homeSet;
            this.away.scoreChanged += awaySet;
            this.date = date;
        }
        public Game(PloegInMatch home, PloegInMatch away, DateTime d)
        {
            homeSetBool = false;
            awaySetBool = false;

            this.home = home;
            this.away = away;
            this.home.scoreChanged += homeSet;
            this.away.scoreChanged += awaySet;

            this.date = d;
        }
        public Game(Ploeg home, Ploeg away, DateTime d, int scoreHome, int scoreAway)
        {
            homeSetBool = false;
            awaySetBool = false;

            this.home = (PloegInMatch) home; //cast de oorspronkelijke klasse naar deze subklasse
            this.away = (PloegInMatch) away;
            this.home.scoreChanged += homeSet;
            this.away.scoreChanged += awaySet;
            this.home.setScore(scoreHome);
            this.away.setScore(scoreAway);
            this.date = d;
        }
        public Game(int id, PloegInMatch home, PloegInMatch away)
        {
            homeSetBool = false;
            awaySetBool = false;
            Id = id;
            this.home = home ?? throw new ArgumentNullException(nameof(home));
            this.away = away ?? throw new ArgumentNullException(nameof(away));
            this.home.scoreChanged += homeSet;
            this.away.scoreChanged += awaySet;
        }
        public Game(int id, PloegInMatch home, PloegInMatch away, int scoreHome, int scoreAway)
        {
            homeSetBool = false;
            awaySetBool = false;
            Id = id;
            this.home = home ?? throw new ArgumentNullException(nameof(home));
            this.away = away ?? throw new ArgumentNullException(nameof(away));
            this.home.scoreChanged += homeSet;
            this.away.scoreChanged += awaySet;
            this.home.setScore(scoreHome);
            this.away.setScore(scoreAway);
        }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("home")]
        public PloegInMatch home { get; set; }
        [JsonProperty("away")]
        public PloegInMatch away { get; set; }
        [JsonProperty("Date")]
        public DateTime date { get; set; } //y m d

        private bool homeSetBool;
        private bool awaySetBool;
        private void homeSet (object s, EventArgs e)
        {
            homeSetBool = true;
           
        }
        private void awaySet(object s, EventArgs e)
        {
            awaySetBool = true;
        }

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
            try
            {
                Game gam = (Game)obj;

            }
            catch (Exception e)
            {
                return false;
            }
            Game ga = (Game)obj;

            return this.Id == ga.Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.Id + ": " + this.home.ToString() + " / " + this.away.ToString();
        }
    }
}
