using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClubBeykersStreet.DomainObjects;

namespace ClubBeykersStreet.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubBeykerStreetesController : ControllerBase
    {
        private readonly ILogger<ClubBeykerStreetesController> _logger;

        public ClubBeykerStreetesController(ILogger<ClubBeykerStreetesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ClubBeykerStreet> GetRoute()
        {
            return new List<ClubBeykersStreet>() 
            { 
                new ClubBeykersStreet() 
                { 
                    Id = 1,
                    Number = "245",
                    Name = "Ст. Октябрьское поле - Ст. МЦД Зорге",
                    Type = TransportType.Bus,
                    Organization = new TransportOrganization()
                    {
                        Id = 1,
                        Name = "Библиотека/Бейкер стрит 221Б",
                        TimeZone = "Europe/Moscow",
                        WebSite = "https://aif.ru/"
                    }
                } 
            };
        }
    }
}
