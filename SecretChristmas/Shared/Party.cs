using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretChristmas.Shared
{
    public class Party
    {
        public int PartyID { get; set; }
        [Required]
        public string PartyName { get; set; }
        
        public PartyGuest PartyHost { get; set; } = new PartyGuest();
        [Required]
        public DateTime PartyDate { get; set; } = DateTime.Now;
    }
}
