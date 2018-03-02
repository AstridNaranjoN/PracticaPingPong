using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;
using System;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Ping
{
    public interface IPingServices
    {
        MessageEventHandler OnMessageStarted  { get; set; }
        Guid PingSendMessage();
        void PingMessageReceived(PingPongMessage message);
        Task WaitReply();
    }
}
