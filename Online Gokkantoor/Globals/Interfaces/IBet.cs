using System;
using Globals.classes;
using static Globals.main;

namespace Globals.Interfaces
{
    public interface IBet
    {
        int Id { get; set; }
        Game game { get; set; }
        Person person { get; set; }
        double cash { get; set; }
        state ploeg { get; set; }
        bool finished { get; set; }
        double getProfit();
    }
}
