using Microsoft.AspNetCore.Mvc;
using SecretChristmas.Shared;

namespace SecretChristmas.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Party>> Get()
        {
            PartyGuest host1 = new()
            {
                PartyGuestID = 1,
                FirstName = "Jacob",
                LastName = "Kepford",
            };

            PartyGuest host2 = new()
            {
                PartyGuestID = 2,
                FirstName = "Bailey",
                LastName = "Wiles"
            };

            PartyGuest host3 = new()
            {
                PartyGuestID = 1,
                FirstName = "Marty",
                LastName = "Cat"
            };



            List<Party> PartyList = new()
            {
                new Party { PartyID = 1, PartyName = "Kepford Christmas", PartyHost = host1, PartyDate = new DateTime (2021, 12, 25)},
                new Party { PartyID = 2, PartyName = "Wiles Wonderland", PartyHost = host2, PartyDate = new DateTime(2021, 12, 15) },
                new Party { PartyID = 3, PartyName = "Marty Grinchmas", PartyHost = host3, PartyDate = new DateTime(2021, 12, 12) }
            };

            return PartyList;
        }
    }
}
