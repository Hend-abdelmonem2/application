using challenge_Diabetes.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace challenge_Diabetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DoctorsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("SelectDoctors")]
        public async Task<IActionResult> GetAll()
        {
            var Doctors=await _context.Doctors.ToListAsync();
            return Ok(Doctors);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return Ok(doctor);
        }
    }
}
