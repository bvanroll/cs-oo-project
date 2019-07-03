using System;
using Globals.Interfaces;

namespace Globals.classes
{
    public class Person : IPerson
    {
        public Person( string name, string lastname, string adress, string gsm, double balance)
        {
            this.name = name;
            this.lastname = lastname;
            this.adress = adress;
            this.gsm = gsm;
            this.balance = balance;
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string adress { get; set; }
        public string gsm { get; set; }
        public double balance { get; set; }

        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            return this.Id == p.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.name + " " + this.lastname;
        }
    }
}
