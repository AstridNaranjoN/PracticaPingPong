using PingPong.Domain.PingPong;

namespace PingPong.ApplicationServices.Pong
{
    public interface IPongMessageService
    {
        PingPongMeasure PongMeassures();
    }
}
