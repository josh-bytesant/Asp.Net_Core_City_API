using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCites()
        {
            return new JsonResult(
                new List<object>() {
                 new { Id = 4, Name = "Ibadan"},
                 new { Id = 5, Name = "Owerri"}
                });
                
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            //return new JsonResult(
            var CitiestoReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if(CitiestoReturn == null)
            {
                return NotFound();
            }

            return Ok(CitiestoReturn);

        }


        [HttpGet("api/cities/all")]
        public IActionResult GetAllPointsOfInterest()
        {
            var Cities = CitiesDataStore.Current.Cities;

            if (Cities == null)
            {
                return NotFound();
            }

            return Ok(Cities);

        }
    }
}
