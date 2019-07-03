using System;
namespace Globals.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string name { get; set; }
        string lastname { get; set; }
        string adress { get; set; }
        string gsm { get; set; }
        double balance { get; set; }

    }
}
