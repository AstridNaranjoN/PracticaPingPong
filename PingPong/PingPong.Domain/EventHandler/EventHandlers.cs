using PingPong.Domain.Pong;

namespace PingPong.Domain.EventHandler
{
    public delegate void MessageEventHandler(PingPongMessage message, string queue);
    public delegate void MessageArriveHandler(PingPongMessage message);
}
