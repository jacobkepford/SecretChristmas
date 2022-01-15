using Microsoft.AspNetCore.Mvc;
using SecretChristmas.Server.Repositories.Interfaces;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyController : ControllerBase
    {
        private readonly ILogger<PartyController> _logger;
        private readonly IPartyRepository _party;

        public PartyController(ILogger<PartyController> logger, IPartyRepository party)
        {
            _logger = logger;
            _party = party;
        }

        [HttpGet]
        public async Task<List<Party>> Get()
        {
            return _party.GetParties();
        }

        [HttpGet("{id}")]
        public async Task<Party> Get(int id)
        {
            return _party.GetParty(id);
        }

        [HttpPost]
        public async void Add(Party party)
        {
            _party.AddParty(party);
        }

        [HttpPut("{id}")]
        public async void Update(Party party, int id)
        {
            _party.UpdateParty(party, id);
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            _party.DeleteParty(id);
        }
    }
}
