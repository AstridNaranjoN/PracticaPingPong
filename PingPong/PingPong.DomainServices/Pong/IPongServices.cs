using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;
using System;

namespace PingPong.DomainServices.Pong
{
    public interface IPongServices
    {
        MessageEventHandler OnMessageStarted { get; set; }
        void PongSendMessage(Guid id);
        void PongMessageReceived(PingPongMessage message);
        string PongMeassures();
    }
}
