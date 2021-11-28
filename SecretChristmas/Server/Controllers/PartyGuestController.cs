﻿using Microsoft.AspNetCore.Mvc;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyGuestController : ControllerBase
    {
        private readonly ILogger<PartyController> _logger;

        private static List<PartyGuest> PartyGuests = new()
        {
            new PartyGuest { PartyGuestID = 1, FirstName = "Jacob", LastName = "Kepford" },
            new PartyGuest { PartyGuestID = 2, FirstName = "Bailey", LastName = "Wiles"  },
            new PartyGuest { PartyGuestID = 3, FirstName = "Marty", LastName = "Cat" }
        };

        public PartyGuestController(ILogger<PartyController> logger)
        {
            _logger = logger;

        }

        [HttpGet]
        public async Task<List<PartyGuest>> Get()
        {
            return PartyGuests;
        }

        [HttpGet("{id}")]
        public async Task<PartyGuest> Get(int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            return selectedPartyGuest;
        }

        [HttpPost]
        public async void Add(PartyGuest partyGuest)
        {
            partyGuest.PartyGuestID = PartyGuests.Max(s => s.PartyGuestID + 1);
            PartyGuests.Add(partyGuest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(PartyGuest partyGuest, int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            selectedPartyGuest.FirstName= partyGuest.FirstName;
            selectedPartyGuest.LastName = partyGuest.LastName;
            return Ok(partyGuest);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            PartyGuest selectedPartyGuest = PartyGuests.FirstOrDefault(s => s.PartyGuestID == id);
            PartyGuests.Remove(selectedPartyGuest);
        }
    }
}