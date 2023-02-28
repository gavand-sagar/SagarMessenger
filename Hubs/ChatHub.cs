using Microsoft.AspNetCore.SignalR;

namespace SagarMessenger.Hubs
{
    public class ChatHub : Hub
    {
        public ChatHub()
        {
            
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine(this.Context.ConnectionId); 
            return base.OnConnectedAsync();
        }
    }
}
