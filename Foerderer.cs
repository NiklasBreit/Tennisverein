using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverein
{
    internal class Foerderer : Mensch
    {
        public Status Status { get; }
        public Foerderer(Status status, string name, string tel, string email) : base(name, tel, email)
        { 
            Status = status;
        }
        public override string GetInfo()
        {
            return base.GetInfo() +"Hat den Status "+Status+Environment.NewLine;
        }
    }
}
