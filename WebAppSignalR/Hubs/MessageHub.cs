using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebAppSignalR.Hubs
{
    public class MessageHub : Hub
    {
        public void SayHello(String message)
        {
            Clients.All.Hello(message);
        }
    }
}