using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverein
{
    internal class Zahlungsdaten
    {
        public string IBan { get; }
        public int Beitrag { get; }
        public bool Bezahlt { get; }
        public Zahlungsdaten(string iban, int beitrag, bool bezahlt) { 

        IBan = iban;
        Beitrag = beitrag;
        Bezahlt = bezahlt;
        }

        public override string ToString()
        {
            string x = "NAME";
            if (Bezahlt)
            {
                return $"Die Person {x} mit der IBan {IBan} hat den Beitrag in Höhe von {Beitrag} EUR Bezahlt.\n";
            }
            else
            {
                return $"Die Person {x} mit der IBan {IBan} den Beitrag in Höhe von {Beitrag} EUR nicht Bezahlt.\n";
            }
        }
    }
}
