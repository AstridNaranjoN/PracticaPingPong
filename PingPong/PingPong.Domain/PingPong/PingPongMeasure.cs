namespace PingPong.Domain.PingPong
{
    public class PingPongMeasure
    {
        public int PingMessagesCount { get; private set; }
        public int PongMessagesCount { get; private set; }

        public PingPongMeasure(int pingMessagesCount, int pongMessagesCount)
        {
            PingMessagesCount = pingMessagesCount;
            PongMessagesCount = pongMessagesCount;
        }
    }
}