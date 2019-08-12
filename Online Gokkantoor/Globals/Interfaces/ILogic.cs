using System;
using System.Collections.Generic;
using Globals.classes;

namespace Globals.Interfaces
{
    public interface ILogic
    {

        void addBet(Bet b);
        void addGame(Game g);
        void addPerson(Person p);
        void addPloeg(Ploeg p);
        void addPloegInMatch(PloegInMatch p);
        Bet getBet(int id);
        List<Bet> GetBets();
        Game getGame(int id);
        List<Game> GetGames();
        Person getPerson(int id);
        List<Person> GetPeople();
        Ploeg getPloeg(string naam);
        List<Ploeg> GetPloegen();
        PloegInMatch GetPloegInMatch(int id);
        List<PloegInMatch> GetPloegInMatches();
        void save();
    }
}
