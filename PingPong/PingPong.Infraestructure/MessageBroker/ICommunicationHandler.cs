using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;

namespace PingPong.Infraestructure.MessageBroker
{
    public interface ICommunicationHandler
    {
        MessageArriveHandler OnMessageArrived { get; set; }
        void SendMessage(PingPongMessage message, string queue);
        void ReceiveMessage(string queue);
    }
}
