using Microsoft.AspNetCore.SignalR;

namespace SignalRWebpack.Hubs;

public class ChatHub : Hub
{
    public void NewMessage(string userName, string message) =>
        Clients.All.SendAsync("newMessage", userName, message);
}