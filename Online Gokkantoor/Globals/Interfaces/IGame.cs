using System;
using Globals.classes;
using static Globals.main;

namespace Globals.Interfaces
{
    public interface IGame
    {
        int Id { get; set; }
        PloegInMatch home { get; set; }
        PloegInMatch away { get; set; }
        DateTime date { get; set; }
        state getWinner();

    }
}
