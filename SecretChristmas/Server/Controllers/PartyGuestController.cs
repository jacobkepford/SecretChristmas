using Microsoft.AspNetCore.Mvc;
using SecretChristmas.Server.Repositories.Interfaces;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyGuestController : ControllerBase
    {
        private readonly ILogger<PartyController> _logger;
        private readonly IHostRepository _partyHost;

        public PartyGuestController(ILogger<PartyController> logger, IHostRepository partyHost)
        {
            _logger = logger;
            _partyHost = partyHost;
        }

        [HttpGet]
        public async Task<List<PartyGuest>> Get()
        {
            return _partyHost.GetHosts();
        }

        [HttpGet("{id}")]
        public async Task<PartyGuest> Get(int id)
        {
            return _partyHost.GetPartyHost(id);
        }

        [HttpPost]
        public async void Add(PartyGuest partyGuest)
        {
            _partyHost.AddPartyHost(partyGuest);
        }

        [HttpPut("{id}")]
        public async void Update(PartyGuest partyGuest, int id)
        {
            _partyHost.UpdatePartyHost(partyGuest, id);
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            _partyHost.DeletePartyHost(id);
        }
    }
}
