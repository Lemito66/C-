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
            if (dbContext.ComentarioEL == null)
            {
                return (IEnumerable<ComentarioEL>)NotFound();
            }
            return await dbContext.ComentarioEL.ToListAsync();
        }

        // GET api/<CustomerEL2Controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComentarioEL>> Get(int id)
        {

            if (dbContext.ComentarioEL == null)
            {
                return NotFound();
            }
            var comentarioEl = await dbContext.ComentarioEL.FindAsync(id);

            if (comentarioEl == null)
            {
                return NotFound();
            }

            return comentarioEl;
        }

        // POST api/<CustomerEL2Controller>
        [HttpPost]
        public async Task<ActionResult<ComentarioEL>> Post(ComentarioEL comentarioEl)
        {

            // ActionResult es una clase que representa un resultado de acción HTTP que puede realizar un controlador.
            // para utilizar los verbos HTTP GET, POST, PUT y DELETE, se debe utilizar ActionResult
            if (dbContext.ComentarioEL == null)
            {
                return Problem("Entity set 'apiRepasoCustomersContext.CustomerEL'  is null.");
            }

            dbContext.Add(comentarioEl);
            await dbContext.SaveChangesAsync();
            return Ok();
            //dbContext.ComentarioEL.Add(comentarioEl);
            //await dbContext.SaveChangesAsync();

            //return CreatedAtAction("GetCustomerEL", new { id = comentarioEl.Id }, comentarioEl);
        }

        // PUT api/<CustomerEL2Controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ComentarioEL comentarioEl)
        {
            if (id != comentarioEl.Id)
            {
                return BadRequest();
            }

            dbContext.Entry(comentarioEl).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComentarioELExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<CustomerEL2Controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (dbContext.ComentarioEL == null)
            {
                return NotFound();
            }
            var comentarioEl = await dbContext.ComentarioEL.FindAsync(id);
            if (comentarioEl == null)
            {
                return NotFound();
            }

            dbContext.ComentarioEL.Remove(comentarioEl);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool ComentarioELExists(int id)
        {
            return (dbContext.ComentarioEL?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
