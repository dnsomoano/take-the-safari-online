using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using take_the_safari_online.Models;

namespace take_the_safari_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        // Class dealing with db declaration for easier referencing
        private SafariVacation2Context db { get; set; }

        public SearchController()
        {
            this.db = new SafariVacation2Context();
        }

        // TODO #1
        // Get request using search instead of animals, querying by species
        // GET api/Search?species={species}
        [HttpGet("?species={species}")]
        public ActionResult<SeenAnimals> Get(string species)
        {
            var location = "";
            var result = new SeenAnimals {
                Species = species,
                LocationOfLastSeen = location,
            };
            // var timeSeen;
            result = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            return result;
        }
        // TODO #2
        // Get animal via by location using endpoint animals/{location}
    };
}