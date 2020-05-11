using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ApiSpark.Hubs
{
    public class Clock : Hub
    {
        public void Hello()
        {
            Clients.Caller.setRealTime(DateTime.Now.ToString("h:mm:ss tt"));
        }
    }
}