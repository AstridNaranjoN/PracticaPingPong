using System;

namespace PingPong.Domain.Pong
{
    public class PingPongMessage
    {
        public Guid Id { get; set; }
        public String Message { get; private set; }

        public PingPongMessage(String message)
        {
            Message = message;
            Id = Guid.NewGuid();
        }

    }
}
