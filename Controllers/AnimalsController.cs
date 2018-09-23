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
    public class AnimalsController : ControllerBase
    {
        private SafariVacation2Context db { get; set; }

        public AnimalsController()
        {
            this.db = new SafariVacation2Context();
        }

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<SeenAnimals>> Get()
        {
            return this.db.SeenAnimals;
        }

        // TODO #2?
        // Get api/animals/{location}

        // POST api/animals/{species}
        [HttpPost]
        public ActionResult<SeenAnimals> Post([FromBody] string species)
        {
            var animal = new SeenAnimals
            {
                Species = species,
                LocationOfLastSeen = "Africa",
                CountOfTimesSeen = 1,
            };

            this.db.SeenAnimals.Add(animal);
            this.db.SaveChanges();
            return animal;
        }

        // PUT api/animals/{species}
        [HttpPut("{species}")]
        public ActionResult<SeenAnimals> Put(string species, [FromBody] string location)
        {
            var updateToAnimal = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            updateToAnimal.CountOfTimesSeen = updateToAnimal.CountOfTimesSeen + 1;
            updateToAnimal.LocationOfLastSeen = location;
            this.db.SaveChanges();
            return updateToAnimal;
        }

        // DELETE api/animals/{species}
        [HttpDelete("{species}")]
        public ActionResult<SeenAnimals> Delete(string species)
        {
            var deleteAnimal = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            this.db.SeenAnimals.Remove(deleteAnimal);
            this.db.SaveChanges();
            return deleteAnimal;
        }
    };
}