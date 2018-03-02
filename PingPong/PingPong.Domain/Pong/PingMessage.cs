using PingPong.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Pong
{
    public class PingMessage : IMessage
    {
        public Guid Id { get; set; }
        public String Message { get; set; }

        public PingMessage(String message)
        {
            Message = message;
            Id = Guid.NewGuid();
        }

    }
}
