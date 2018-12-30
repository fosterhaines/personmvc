using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personapi.Models;

namespace personapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values/getstates
        [HttpGet("GetStates")]
        public ActionResult<IEnumerable<States>> GetStates()
        {
            PersonContext _context = new PersonContext();
            return _context.States.FromSql("uspStatesList").ToList();
        }

        // GET api/values/getperson
        [HttpGet("GetPerson")]
        public ActionResult<IEnumerable<Person>> GetPerson()
        {
            PersonContext _context = new PersonContext();
            return _context.Person.FromSql("uspPersonSearch").ToList();
        }

    }
}
