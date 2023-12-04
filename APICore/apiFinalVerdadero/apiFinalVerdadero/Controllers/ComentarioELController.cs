using Microsoft.AspNetCore.Mvc;
using apiFinalVerdadero.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiFinalVerdadero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioELController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public  ComentarioELController(ApplicationDbContext context)
        {
            dbContext = context;
        }       

        // GET: api/<CustomerEL2Controller>
        [HttpGet]
        public async Task<IEnumerable<ComentarioEL>> Get()
        {
            return await dbContext.ComentarioEL.ToListAsync();
        }

        // GET api/<CustomerEL2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerEL2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerEL2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerEL2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
