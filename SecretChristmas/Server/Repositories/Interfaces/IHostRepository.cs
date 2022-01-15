using SecretChristmas.Shared;

namespace SecretChristmas.Server.Repositories.Interfaces
{
    public interface IHostRepository
    {
        List<PartyGuest> GetHosts();
        PartyGuest GetPartyHost(int id);
        void AddPartyHost(PartyGuest partyGuest);
        void UpdatePartyHost(PartyGuest partyGuest, int id);
        void DeletePartyHost(int id);
    }
}
