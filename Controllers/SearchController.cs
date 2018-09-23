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
        // Nested Classes dealing with db declaration for easier referencing
        private SafariVacation2Context db { get; set; }

        public SearchController()
        {
            this.db = new SafariVacation2Context();
        }

        // Container class
        public class ResponseObject
        {
            public bool WasSuccessful { get; set; }
            public Object result { get; set; }
        }

        // GET api/Search?species={species}
        [HttpGet]
        public ActionResult<ResponseObject> Get([FromQuery] string species)
        {
            // var location = "";
            // var result = new SeenAnimals {
            //     Species = species,
            //     LocationOfLastSeen = location,
            // };
            // result = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            // return result;
            var _rv = new ResponseObject
            {
                WasSuccessful = true,
                result = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species),
            };
            if (species != null)
            {
                return _rv;
            }
            else
            {
                _rv.WasSuccessful = false;
                _rv.result = "Animal not found";
                return _rv;
            }
        }
        // TODO #2
        // Get animal via by location using endpoint animals/{location}
    };
}