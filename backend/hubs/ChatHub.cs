// Wesley Murray
// 2/23/2021

namespace backend.hubs {
    public class ChatHub: Hub{
        public async Task SendMessage(ChatMessage message){
            await Clients.All.SendAsync("RecieveMessage",message);
        }
    }
}