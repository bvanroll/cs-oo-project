﻿using System;
using System.Collections.Generic;
using Data;
using Globals.classes;
using Globals.Interfaces;

namespace Logic
{
    public class LogicLayer : ILogic
    {
        private dataLayer d;

        public LogicLayer()
        {
            d = new dataLayer();

            persons = d.getPersons();
            bets = d.getBets();
            ploegen = d.getPloegen();
            games = d.getGames();
        }

        public LogicLayer(bool testMode)
        {
            d = new dataLayer();
            this.persons = new List<Person>();
            Person p = new Person("beppe", "vanrolleghem", "123straat", "04877777", 5);
            fixIds();
            this.persons.Add(p);
        }

        public List<Person> persons { get ; set; }
        public List<Bet> bets { get; set; }
        public List<Ploeg> ploegen { get; set; }
        public List<Game> games { get; set; }

        private void fixIds()
        {
            int i = 0;
            foreach(Person p in persons)
            {
                p.Id = i;
                i++;
            }
            i = 0;
            foreach(Bet b in bets)
            {
                b.Id = i;
                i++;
            }
            i = 0;
            foreach(Ploeg p in ploegen)
            {
                p.Id = i;
                i++;
            }
            i = 0;
            foreach(Game g in games)
            {
                g.Id = i;
                i++;
            }
        }

        public void addBet(Bet b)
        {
            
            bets.Add(b);
            fixIds();
        }

        public void addGame(Game g)
        {
            games.Add(g);
            fixIds();
        }

        public void addPerson(Person p)
        {
            persons.Add(p);
            fixIds();
        }

        public void addPloeg(Ploeg p)
        {
            ploegen.Add(p);
            fixIds();
        }

        public Bet getBet(int id)
        {
            foreach(Bet b in bets)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }

        public Game getGame(int id)
        {
            foreach (Game b in games)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }

        public Person getPerson(int id)
        {
            foreach (Person b in persons)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }

        public Ploeg getPloeg(int id)
        {
            foreach (Ploeg b in ploegen)
            {
                if (b.Id == id) return b;
            }
            throw new Exception("No bets found with that id");
        }
        public void save()
        {
            fixIds();
            d.saveBets(bets);
            d.saveGames(games);
            d.savePersons(persons);
            d.savePloegen(ploegen);
        }

        public void updateGame(Game g)
        {
            foreach (Game ga in games)
            {
                if (ga.Id == g.Id)
                {
                    ga.home = g.home;
                    ga.away = g.away;
                   
                }
            }
            updateBets();
            updateBalances();
        }

        private void updateBets()
        {
            foreach (Bet b in bets)
            {
                Game g = games.Find(e => b.game.Id == e.Id);
                b.game = g;
                if (g.away.scoreSet && g.home.scoreSet) { b.finished = true; }
            }
            
        }
        private void updateBalances()
        {
            foreach (Person p in persons)
            {
                foreach (Bet b in bets)
                {
                    if (b.Equals(p) && b.finished) p.balance += b.getProfit();
                }
            }
        }

        public void updatePerson(Person p)
        {
            persons[persons.FindIndex(e => e.Id == p.Id)] = p;            
        }
    }
}