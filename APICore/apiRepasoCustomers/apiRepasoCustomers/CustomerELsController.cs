using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiRepasoCustomers.Data;
using apiRepasoCustomers.Models;

namespace apiRepasoCustomers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerELsController : ControllerBase
    {
        private readonly apiRepasoCustomersContext _context;

        public CustomerELsController(apiRepasoCustomersContext context)
        {
            _context = context;
        }

        // GET: api/CustomerELs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerEL>>> GetCustomerEL()
        {
          if (_context.CustomerEL == null)
          {
              return NotFound();
          }
            return await _context.CustomerEL.ToListAsync();
        }

        // GET: api/CustomerELs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerEL>> GetCustomerEL(int id)
        {
          if (_context.CustomerEL == null)
          {
              return NotFound();
          }
            var customerEL = await _context.CustomerEL.FindAsync(id);

            //var customerEl = await _context.CustomerEL.FirstOrDefaultAsync(m => m.Id == id); // me aseguro que no sea null

            if (customerEL == null)
            {
                return NotFound();
            }

            return customerEL;
        }

        // PUT: api/CustomerELs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerEL(int id, CustomerEL customerEL)
        {
            if (id != customerEL.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerEL).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerELExists(id))
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

        // POST: api/CustomerELs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerEL>> PostCustomerEL(CustomerEL customerEL)
        {
          if (_context.CustomerEL == null)
          {
              return Problem("Entity set 'apiRepasoCustomersContext.CustomerEL'  is null.");
          }
            _context.CustomerEL.Add(customerEL);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerEL", new { id = customerEL.Id }, customerEL);
        }

        // DELETE: api/CustomerELs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerEL(int id)
        {
            if (_context.CustomerEL == null)
            {
                return NotFound();
            }
            var customerEL = await _context.CustomerEL.FindAsync(id);
            if (customerEL == null)
            {
                return NotFound();
            }

            _context.CustomerEL.Remove(customerEL);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerELExists(int id)
        {
            return (_context.CustomerEL?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
