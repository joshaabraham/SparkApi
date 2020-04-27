using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost.hubs
{
    public class NotificationHub: Hub
    {

        public void ServerTime()
        {
            Clients.All.displaTime($"{DateTime.UtcNow:T}");
        }
    }
}
