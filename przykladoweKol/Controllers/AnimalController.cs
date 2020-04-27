using Microsoft.AspNetCore.Mvc;
using przykladoweKol.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKol.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetAnimals([FromServices] IAnimalDal _animalDal ,string sortBy)
        //{
        //    return Ok("halo");
        //    var list = _animalDal.GetAnimals(sortBy);
        //    return Ok(list);
        //}

        [HttpGet]
        public IActionResult GetAnimals([FromServices] IAnimalDal _animalDal)
        {
         
            return Ok("halo");
        }
    }
}
