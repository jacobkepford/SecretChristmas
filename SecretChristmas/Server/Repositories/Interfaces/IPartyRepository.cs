using SecretChristmas.Shared;

namespace SecretChristmas.Server.Repositories.Interfaces
{
    public interface IPartyRepository
    {
        List<Party> GetParties();
        Party GetParty(int id);
        void AddParty(Party party);
        void UpdateParty(Party party, int id);
        void DeleteParty(int id);
    }
}
