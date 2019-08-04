using System;
namespace Globals.Interfaces
{
    public interface IPloeg
    {
        int Id { get; set; }
        string naam { get; set; }
        int score { get; }
        bool scoreSet { get; }
        event EventHandler scoreChanged;
        void setScore(int i);
        int getScore();
    }
}
