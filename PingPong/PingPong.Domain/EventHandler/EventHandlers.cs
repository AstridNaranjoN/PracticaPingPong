using PingPong.Domain.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.EventHandler
{
    public delegate void MessageEventHandler(PingPongMessage message, string queue);
    public delegate void MessageArriveHandler(PingPongMessage message);
}
