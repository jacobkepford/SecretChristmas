using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretChristmas.Shared
{
    public class Party
    {
        public int PartyID { get; set; }
        public string PartyName { get; set; }
        public PartyGuest PartyHost { get; set; }
        public DateTime PartyDate { get; set; }
    }
}
