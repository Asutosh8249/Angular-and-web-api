using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComplexProjet.Models;

namespace ComplexProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchesController : ControllerBase
    {
        private readonly ComplexContext _context;

        public SearchesController(ComplexContext context)
        {
            _context = context;
        }

        // GET: api/Searches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Search>>> Getsearch()
        {
            return await _context.search.ToListAsync();
        }

        // GET: api/Searches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Search>> GetSearch(int id)
        {
            var search = await _context.search.FindAsync(id);

            if (search == null)
            {
                return NotFound();
            }

            return search;
        }

        // PUT: api/Searches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSearch(int id, Search search)
        {
            if (id != search.searchId)
            {
                return BadRequest();
            }

            _context.Entry(search).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SearchExists(id))
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

        // POST: api/Searches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Search>> PostSearch(Search search)
        {
            _context.search.Add(search);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSearch", new { id = search.searchId }, search);
        }

        // DELETE: api/Searches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Search>> DeleteSearch(int id)
        {
            var search = await _context.search.FindAsync(id);
            if (search == null)
            {
                return NotFound();
            }

            _context.search.Remove(search);
            await _context.SaveChangesAsync();

            return search;
        }

        private bool SearchExists(int id)
        {
            return _context.search.Any(e => e.searchId == id);
        }
    }
}
