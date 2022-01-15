using SecretChristmas.Server.Repositories.Interfaces;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Repositories
{
    public class HostRepository : IHostRepository
    {
        private static List<PartyGuest> PartyGuests = new()
        {
            new PartyGuest { PartyGuestID = 1, PartyGuestName = "Jacob Kepford" },
            new PartyGuest { PartyGuestID = 2, PartyGuestName = "Bailey Wiles" },
            new PartyGuest { PartyGuestID = 3, PartyGuestName = "Marty Cat" }
        };

        public List<PartyGuest> GetHosts()
        {
            return PartyGuests;
        }

        public PartyGuest GetPartyHost(int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            return selectedPartyGuest;
        }

        public void AddPartyHost(PartyGuest partyGuest)
        {
            partyGuest.PartyGuestID = PartyGuests.Max(s => s.PartyGuestID + 1);
            PartyGuests.Add(partyGuest);
        }

        public void UpdatePartyHost(PartyGuest partyGuest, int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            selectedPartyGuest.PartyGuestName = partyGuest.PartyGuestName;
        }

        public void DeletePartyHost(int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            PartyGuests.Remove(selectedPartyGuest);
        }
    }
}
