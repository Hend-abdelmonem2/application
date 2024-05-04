using challenge_Diabetes.Data;
using challenge_Diabetes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace challenge_Diabetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Selecting_dataController : ControllerBase
    { private readonly ApplicationDbContext _context;
       
        public Selecting_dataController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        [HttpGet("user's sugar_data")]
        public async Task<IActionResult> sugar_data()
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var  sugardata = _context.measuring_Sugars.Where(x => x.User_Id == userid).ToList();
            return Ok(sugardata);
        }
        [HttpGet("user's presure_data")]

        public async Task< IActionResult> pressure_data()
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var pressuredata=_context.measuring_Pressures.Where(y=>y.User_Id==userid).ToList();
            
            return Ok(pressuredata);
        }

        [HttpGet("user's weight_data")]
         
        public async Task<IActionResult> weight_data()
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var weightdata=_context.measuring_Weights.Where(w=>w.User_Id==userid).ToList();

            return Ok(weightdata);
        }


    }
}
