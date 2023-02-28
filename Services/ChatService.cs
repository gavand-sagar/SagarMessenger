using Microsoft.AspNetCore.SignalR;
using SagarMessenger.Hubs;

namespace SagarMessenger.Services
{
    public class ChatService
    {
        IHubContext<ChatHub> _hubContext;
        public ChatService(IHubContext<ChatHub> hubContext) { 
            this._hubContext = hubContext;
            
        }

        public async Task SendMessage(Message message)
        {
            await this._hubContext.Clients.All.SendAsync(MessageTypes.Brodcast, message);
        }
    }
}
