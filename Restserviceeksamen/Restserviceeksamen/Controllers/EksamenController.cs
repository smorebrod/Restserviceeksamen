using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restserviceeksamen.model;

namespace Restserviceeksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EksamenController : ControllerBase
    {
        private static List<Parkering> cList = new List<Parkering>
        {
            new Parkering(1,"AR12345",5,5,25,"01.05.2018"),
            new Parkering(2,"BR45612",2,10,20,"01-05-2019"),
            new Parkering(3,"DG26482",8,0,0,"3-05-2019"),
            new Parkering(4,"BR45612",4,5,20,"3-05-2019"),
            new Parkering(5,"BR45612",5,5,25,"4-05-2019")
        };




        // GET: api/Parkering
        [HttpGet]
        public List<Parkering> get()
        {
            return cList;
        }

        // GET: api/Parkering/5
        [HttpGet("{id}", Name = "Get")]
        public Parkering GetParkering(int id)
        {
            Parkering c = cList.FirstOrDefault(Parkering => Parkering.ID == id);
            
            return c;
        }

        // POST: api/Eksamen
        [HttpPost]
        public Parkering InsertParkering([FromBody] Parkering pakering)
        {
            cList.Add(pakering);
            return pakering;

        }

        // PUT: api/Eksamen/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
