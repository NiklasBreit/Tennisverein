using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverein
{
    internal class Mitglied : Mensch
    {
        public Zahlungsdaten Zahlungsdaten { get; }

        public Mitglied(string name, string email, string tel,Zahlungsdaten daten) : base(name,tel,email)
        {
            Zahlungsdaten = daten;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}{Zahlungsdaten.ToString().Replace("NAME",Name)}";
        }
    }
}
