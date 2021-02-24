// Wesley Murray
// 2/23/2021

using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using backend.models;
using backend.hubs.clients;
using System;

namespace backend.hubs {
    public class ChatHub: Hub<IChatClient>{
        public async Task SendMessage(ChatMessage message){
            Console.WriteLine(message.User);
            Console.WriteLine(message.Message);
            // await Clients.All.RecieveMessage(message);
            await Clients.All.RecieveMessage(message.User,message.Message);
        }
    }
}