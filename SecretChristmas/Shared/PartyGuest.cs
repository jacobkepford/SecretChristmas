using System.ComponentModel.DataAnnotations;

namespace SecretChristmas.Shared
{
    public class PartyGuest
    {
        public int PartyGuestID { get; set; }
        [Required]
        public string PartyGuestName { get; set; }
        
    }
}