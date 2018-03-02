using PingPong.Domain.Contract;
using PingPong.Domain.EventHandler;
using System;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Ping
{
    public interface IPingServices
    {
        MessageEventHandler OnMessageStarted  { get; set; }
        Guid PingSendMessage();
        void PingMessageReceived(IMessage message);
        Task WaitReply();
    }
}
