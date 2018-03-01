using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Ping
{
    class PingMessageStarted
    {
        public String Message { get; private set; }

        public PingMessageStarted(String message)
        {
            Message = message;

        }
    }
}
