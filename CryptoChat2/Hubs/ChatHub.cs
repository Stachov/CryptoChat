using Microsoft.AspNetCore.SignalR;

namespace CryptoChat2.Hubs
{
    public class ChatHub :Hub
    {
        public async Task SendMessage(string username, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", username, message);
        }
    }
}
