using System;
using Globals.classes;
using static Globals.main;

namespace Globals.Interfaces
{
    public interface IGame
    {
        int Id { get; set; }
        Ploeg home { get; set; }
        Ploeg away { get; set; }
        DateTime date { get; set; }
        state getWinner();

    }
}
