using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void sendMessage(string name, string message)
        {
            Clients.All.newMessage(name, message);
        }
    }
}