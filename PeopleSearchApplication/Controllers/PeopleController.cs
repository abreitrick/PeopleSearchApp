using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PeopleSearchApplication.Models;

namespace PeopleSearchApplication.Controllers
{
    [RoutePrefix("api/people")]
    public class PeopleController : ApiController
    {
        private PeopleSearchApplicationContext db = new PeopleSearchApplicationContext();

        // GET: api/People
        [Route("")]
        public IQueryable<People> GetPeople()
        {
            return db.People;
        }

        // GET: api/People/5
        [Route("{id:int}")]
        [ResponseType(typeof(People))]
        public async Task<IHttpActionResult> GetPeople(int id)
        {
            People people = await db.People.FindAsync(id);
            if (people == null)
            {
                return NotFound();
            }

            return Ok(people);
        }

        // PUT: api/People/5
        [Route("id/people")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeople(int id, People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != people.Id)
            {
                return BadRequest();
            }

            db.Entry(people).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
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

        // POST: api/People
        [HttpPost]
        [Route("people")]
        [ResponseType(typeof(People))]
        public async Task<IHttpActionResult> PostPeople(People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.People.Add(people);
            await db.SaveChangesAsync();

            //return CreatedAtRoute("people", new { id = people.Id }, people);
            return Ok(people);
        }

        // DELETE: api/People/5
        [HttpDelete]
        [Route("{id}")]
        [ResponseType(typeof(People))]
        public async Task<IHttpActionResult> DeletePeople(int id)
        {
            People people = await db.People.FindAsync(id);
            if (people == null)
            {
                return NotFound();
            }

            db.People.Remove(people);
            await db.SaveChangesAsync();

            return Ok(people);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeopleExists(int id)
        {
            return db.People.Count(e => e.Id == id) > 0;
        }
    }
}