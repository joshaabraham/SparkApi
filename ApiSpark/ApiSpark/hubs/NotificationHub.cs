using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.hubs
{
    public class NotificationHub: Hub
    {

        public static void PostToClient(string data)
        {
            try
            {
                var chat = GlobalHost.ConnectionManager.GetHubContext("Requestlog");
                if (chat != null)
                    chat.Clients.All.postToClient(data);
            }
            catch(Exception e)
            {
                throw e;

            }
        }


        public void ServerTime()
        {
            Clients.All.displayTime($"{DateTime.UtcNow:T}");
        }
    }
}
