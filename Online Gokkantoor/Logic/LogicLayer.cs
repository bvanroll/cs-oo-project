using System;
using System.Collections.Generic;
using Data;
using Globals.classes;
using Globals.Interfaces;

namespace Logic
{
    public class LogicLayer : ILogic
    {
        private dataLayer data;

        private db d;
        public LogicLayer()
        {
            data = new dataLayer();
            d = data.getDb();
            if (d.games == null) d.games = new List<Game>();
            if (d.ploegen == null) d.ploegen = new List<Ploeg>();
            if (d.persons == null) d.persons = new List<Person>();
            if (d.bets == null) d.bets = new List<Bet>();
            if (d.ploegInMatches == null) d.ploegInMatches = new List<PloegInMatch>();
        }

        public void addBet(Bet b)
        {

            d.bets.Add(b);
        }

        public void addGame(Game g)
        {
            d.games.Add(g);
        }

        public void addPerson(Person p)
        {
            d.persons.Add(p);
        }

        public void addPloeg(Ploeg p)
        {
            d.ploegen.Add(p);
        }

        public void addPloegInMatch(PloegInMatch p)
        {
            d.ploegInMatches.Add(p);
        }

        public Bet getBet(int id)
        {
            foreach(Bet b in d.bets)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }

        public List<Bet> GetBets()
        {
            return d.bets;
        }

        public Game getGame(int id)
        {
            foreach (Game b in d.games)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }

        public List<Game> GetGames()
        {
            return d.games;
        }

        public List<Person> GetPeople()
        {
            return d.persons;
        }

        public Person getPerson(int id)
        {
            return d.persons.FindLast(x => id == x.Id); //lambda 
            
        }

        public Ploeg getPloeg(string naam)
        {
            foreach (Ploeg b in d.ploegen)
            {
                if (b.naam == naam) return b;
            }
            throw new Exception("No ploegen found with that naam");
        }

        public List<Ploeg> GetPloegen()
        {
            return d.ploegen;
        }

        public PloegInMatch GetPloegInMatch(int id)
        {

            foreach (PloegInMatch b in d.ploegInMatches)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No ploegen found with that naam");
        }

        public List<PloegInMatch> GetPloegInMatches()
        {
            return d.ploegInMatches;
        }

        public void save()
        {
            data.saveDb(d);
        }

    }
}
