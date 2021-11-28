using System.ComponentModel.DataAnnotations;

namespace SecretChristmas.Shared
{
    public class PartyGuest
    {
        public int PartyGuestID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}