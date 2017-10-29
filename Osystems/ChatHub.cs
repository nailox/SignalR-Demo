using Microsoft.AspNet.SignalR;

namespace Osystems
{
    public class ChatHub : Hub
    {
        public void ReceiveNotification(Message message)
        {
            Clients.All.receiveNotification(message);


        }
    }
}