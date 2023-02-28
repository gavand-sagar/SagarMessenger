using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SagarMessenger.Services;

namespace SagarMessenger.Controllers
{
    [Route("api/chats")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        //ChatService chatService;
        //public ChatController(ChatService chatService)
        //{
        //    this.chatService = chatService;
        //}

        [HttpPost("send")]
        public Task<string> SendMessage([FromBody] Message message)
        {
            return Task.FromResult("Sent");
            //return chatService.SendMessage(message);
        }

        [HttpGet()]
        public async Task<IEnumerable<string>> GetMessages() {

            return await Task.FromResult(new string[] { "Apple","Mango" });

        }

    }
}
