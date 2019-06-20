using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19.Hubs
{
    public class ChatHub : Hub
    {

        public void fnTest()
        {

        }

        public string getCompanyName()
        {
            return "abcStore";
        }

        public int addTwoNumber(int num1,int num2)
        {
            Clients.All.SendAsync("display", num1 + num2);
            return num1 + num2;
        }

        public void sendMessage(string name,string msg)
        {
            Clients.All.SendAsync("display", name, msg);
        }
    }
}
