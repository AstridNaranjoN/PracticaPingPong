using PingPong.Domain.Contract;
using PingPong.Domain.EventHandler;
using System;

namespace PingPong.DomainServices.Pong
{
    public interface IPongServices
    {
        MessageEventHandler OnMessageStarted { get; set; }
        void PongSendMessage(Guid id);
        void PongMessageReceived(IMessage message);
        string PongMeassures();
    }
}
