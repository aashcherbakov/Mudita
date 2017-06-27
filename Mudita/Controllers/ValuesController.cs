using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mudita.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            /*
             * For you header
             * 
             * 1
             * a new standard
             * sustained peak performance 
             * 
             * 2. nutrition guide
             * TB12 nutrition philosophy
             * 
             * 3. the weakly workout
             * focus of the day
             * 
             * 4. workout essentials 
             * Gear up
             * 
             * 5. Recipe of the day
             * Black bean burger
             */
            return new string[] { 
                "Rookie workout", 
                "Let's Go!" 
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
