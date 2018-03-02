using PingPong.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.EventHandler
{
    public delegate void MessageEventHandler(IMessage message, string queue);
    public delegate void MessageArriveHandler(IMessage message);
}
