using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp_AppAPI.Data.DatabaseContext;
using SchoolApp_AppAPI.Models;

namespace SchoolApp_AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly SchoolDBContext _context;

        public HostelController(SchoolDBContext context)
        {
            _context = context;
        }

        // GET: api/Hostel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hostel>>> GetHostels()
        {
            return await _context.Hostels.ToListAsync();
        }

        // GET: api/Hostel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hostel>> GetHostel(int id)
        {
            var hostel = await _context.Hostels.FindAsync(id);

            if (hostel == null)
            {
                return NotFound();
            }

            return hostel;
        }

        // POST: api/Hostel
        [HttpPost]
        public async Task<ActionResult<Hostel>> PostHostel(Hostel hostel)
        {
            _context.Hostels.Add(hostel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHostel", new { id = hostel.Id }, hostel);
        }

        // DELETE: api/Hostel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hostel>> DeleteCourse(int id)
        {
            var hostel = await _context.Hostels.FindAsync(id);
            if (hostel == null)
            {
                return NotFound();
            }

            _context.Hostels.Remove(hostel);
            await _context.SaveChangesAsync();

            return hostel;
        }
        //// PUT: api/Hostel/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHostel(int id, Hostel hostel)
        //{
        //    if (id != hostel.Id)
        //    {
        //        return
    }
}
