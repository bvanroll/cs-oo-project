using System;
using System.Collections.Generic;
using Globals.classes;

namespace Globals.Interfaces
{
    public interface IData
    {
        List<Person> getPersons();
        List<Game> getGames();
        List<Ploeg> getPloegen();
        List<Bet> getBets();
        void saveBets(List<Bet> b);
        void saveGames(List<Game> g);
        void savePloegen(List<Ploeg> p);
        void savePersons(List<Person> p);
    }
}
