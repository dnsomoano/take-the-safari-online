using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using take_the_safari_online.Models;

namespace take_the_safari_online.Controllers
{
    [Route("api/[controller]/?species=")]
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
        // [HttpGet("?species={Species}")]
        // public ActionResult<IEnumerable<SeenAnimals>> Get([FromQuery] string species)
        // {
        //     // var location = "";
        //     // var timesSeen = 0;

        //     var speciesResult = this.db.SeenAnimalsTable.FirstOrDefault(result => result.Species == species);
        //     // var searchQuery = new SeenAnimals
        //     // {
        //     //     Species = speciesResult,
        //     //     // LocationOfLastSeen = location,
        //     //     // CountOfTimesSeen = timesSeen,
        //     // };
        //     return speciesResult.ToString();
        // }

        // Post request for an animal
        // [HttpPost]
        // public ActionResult<SeenAnimals> Post([FromBody] string species)
        // {
        //     var animal = new SeenAnimals
        //     {
        //         Species = species,
        //         LocationOfLastSeen = "Africa",
        //         CountOfTimesSeen = 1,
        //     };

        //     this.db.SeenAnimalsTable.Add(animal);
        //     this.db.SaveChanges();
        //     return animal;
        // }

        // Get request using search instead of animals, querying by species
        // Get animal via by location using endpoint animals/{location}
        // Put request using endpoint animals/{animal} the add one to the count seen for an animal
        // delete request using endpoint animal/{animal} that deletes an animal from the table
    };
}