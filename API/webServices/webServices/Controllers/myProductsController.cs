using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webServices.Models;

namespace webServices.Controllers
{
    public class myProductsController : ApiController
    {
        private dbDeltaNov2023Entities1 db = new dbDeltaNov2023Entities1();

        // GET: api/myProducts
        public IQueryable<misProductos> GetmisProductos()
        {
            return db.misProductos;
        }

        // GET: api/myProducts/5
        [ResponseType(typeof(misProductos))]
        public IHttpActionResult GetmisProductos(int id)
        {
            misProductos misProductos = db.misProductos.Find(id);
            if (misProductos == null)
            {
                return NotFound();
            }

            return Ok(misProductos);
        }

        // PUT: api/myProducts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutmisProductos(int id, misProductos misProductos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != misProductos.id)
            {
                return BadRequest();
            }

            db.Entry(misProductos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!misProductosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/myProducts
        [ResponseType(typeof(misProductos))]
        public IHttpActionResult PostmisProductos(misProductos misProductos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.misProductos.Add(misProductos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = misProductos.id }, misProductos);
        }

        // DELETE: api/myProducts/5
        [ResponseType(typeof(misProductos))]
        public IHttpActionResult DeletemisProductos(int id)
        {
            misProductos misProductos = db.misProductos.Find(id);
            if (misProductos == null)
            {
                return NotFound();
            }

            db.misProductos.Remove(misProductos);
            db.SaveChanges();

            return Ok(misProductos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool misProductosExists(int id)
        {
            return db.misProductos.Count(e => e.id == id) > 0;
        }
    }
}