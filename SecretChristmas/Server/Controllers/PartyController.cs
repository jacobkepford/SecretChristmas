﻿using Microsoft.AspNetCore.Mvc;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyController : ControllerBase
    {
        private readonly ILogger<PartyController> _logger;

        private static PartyGuest host1 = new()
        {
            PartyGuestID = 1,
            PartyGuestName = "Jacob Kepford"
        };

        private static PartyGuest host2 = new()
        {
            PartyGuestID = 2,
            PartyGuestName = "Bailey Wiles"
        };

        private static PartyGuest host3 = new()
        {
            PartyGuestID = 1,
            PartyGuestName = "Marty Cat"
        };

        private static List<Party> PartyList = new()
        {
            new Party { PartyID = 1, PartyName = "Kepford Christmas", PartyHost = host1, PartyDate = new DateTime(2021, 12, 25) },
            new Party { PartyID = 2, PartyName = "Wiles Wonderland", PartyHost = host2, PartyDate = new DateTime(2021, 12, 15) },
            new Party { PartyID = 3, PartyName = "Marty Grinchmas", PartyHost = host3, PartyDate = new DateTime(2021, 12, 12) }
        };

        public PartyController(ILogger<PartyController> logger)
        {
            _logger = logger;

        }

        [HttpGet]
        public async Task<List<Party>> Get()
        {
            return PartyList;
        }

        [HttpGet("{id}")]
        public async Task<Party> Get(int id)
        {
            Party selectedParty = PartyList.FirstOrDefault(s => s.PartyID == id);
            return selectedParty;
        }

        [HttpPost]
        public async void Add(Party party)
        {
            party.PartyID = PartyList.Max(s => s.PartyID + 1);
            PartyList.Add(party);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Party party, int id)
        {
            Party selectedParty = PartyList.FirstOrDefault(s => s.PartyID == id);
            selectedParty.PartyName = party.PartyName;
            selectedParty.PartyHost = party.PartyHost;
            selectedParty.PartyDate = party.PartyDate;
            return Ok(party);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Party selectedParty = PartyList.FirstOrDefault(s => s.PartyID == id);
            PartyList.Remove(selectedParty);
        }
    }
}
