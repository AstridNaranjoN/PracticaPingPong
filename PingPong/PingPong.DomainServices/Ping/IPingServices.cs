using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Ping
{
    public interface IPingServices
    {
        EventHandler OnReceiveMessage  { get; set; }
        void PingSendMessage();
    }
}
