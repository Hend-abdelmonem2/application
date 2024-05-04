using challenge_Diabetes.DTO;
using challenge_Diabetes.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;


namespace challenge_Diabetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<chathub> _chatHub;

        public ChatController(IHubContext<chathub> chatHub)
        {
            _chatHub = chatHub;
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] MessageDTO message)
        {
            // Process the message, then send it to clients via SignalR
            await _chatHub.Clients.All.SendAsync("ReceiveMessage", message.Text);
            return Ok();
        }


    }
}
