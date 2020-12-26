using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAssesment.Model;
using GAssesment.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GAssesment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryGwpController : ControllerBase
    {
        private readonly IGwpCountryRepository _gwpCountryRepository;
        public CountryGwpController(IGwpCountryRepository gwpCountryRepository  )
        {
            _gwpCountryRepository = gwpCountryRepository;

        }       

        // POST api/<CountryGwp>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InputData input)
        {
            try
            {
                var output = await _gwpCountryRepository.GetAvgGrossbyLob(input);
                return StatusCode(200, output);
            }
            catch(Exception ex)
            {

                return StatusCode(500, ex);//Internal error
            }
        }

     

       
    }
}
