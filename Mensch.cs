using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverein
{
    internal class Mensch
    {
        public string Name { get; }
        public string Telefonnummer { get; }
        public string EMail {get;}

        public Mensch(string name,string tel, string email)
        {
            Name = name;
            Telefonnummer = tel;
            EMail = email;
        }
        public virtual string GetInfo()
        {
            return $"Name: {Name}\nTelefonnummer: {Telefonnummer}\nEmail: {EMail}\n";
        }
    }
}
