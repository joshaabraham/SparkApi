using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ApiSpark.hubs
{
    public class ChatHub : Hub
    {

        public async Task PostMessage (string userId, string name, string message)
        {
            await Clients.User(userId).addNewMessageToPage(name, message);
            await Clients.Caller.notifyMessageSent();
        }

        public async Task JoinGroup(string groupName)
        {
            await Groups.Add(Context.ConnectionId, groupName);
        }

        public async Task LeaveGroup(string groupName)
        {
            await Groups.Remove(Context.ConnectionId, groupName);
        }
    }
}