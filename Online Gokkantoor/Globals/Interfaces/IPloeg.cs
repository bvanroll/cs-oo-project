using System;
namespace Globals.Interfaces
{
    public interface IPloeg
    {
        int Id { get; set; }
        string naam { get; set; }
        int score { get; set; }
        bool scoreSet { get; }
    }
}
