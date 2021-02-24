// Wesley Murray
// 2/23/2021

using System.Threading.Tasks;
using backend.models;

namespace backend.hubs.clients{
    public interface IChatClient
    {
        // Task RecieveMessage(ChatMessage message)
        Task RecieveMessage(string user, string message)
;    }
}