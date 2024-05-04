using challange_Diabetes.DTO;
using challange_Diabetes.Model;
using challenge_Diabetes.Data;
using challenge_Diabetes.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace challenge_Diabetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MedicineController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("AddMedicines")]
        public IActionResult addMedicines([FromForm] medicineDTO medicines)
        {
            var medicine = new Medicine
            {
                Name = medicines.Name,
                Dosage = medicines.Dosage,
                times = medicines.times,
                Date = DateTime.Now

            };
            var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            medicine.User_Id = userid;
            _context.Add(medicine);
            _context.SaveChanges();

            return Ok(medicine);
        }

        [HttpGet("Get medicines for user")]
          public IActionResult GetMedicines()
          {
              var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var medicines = _context.medicines.Where(y => y.User_Id == userid).ToList();
            return Ok(medicines);
          }
    }
}
