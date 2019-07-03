using System;
using System.Collections.Generic;
using Globals.classes;

namespace Globals.Interfaces
{
    public interface ILogic
    {
        List<Person> persons { get; set; }
        List<Bet> bets { get; set; }
        List<Ploeg> ploegen { get; set; }
        List<Game> games { get; set; }
        Person getPerson(int id);
        Bet getBet(int id);
        Ploeg getPloeg(int id);
        Game getGame(int id);
        void addPloeg(Ploeg p);
        void addGame(Game g);
        void addBet(Bet b);
        void addPerson(Person p);
        void save();
        void updateGame(Game g);
        void updatePerson(Person p);
    }
}
