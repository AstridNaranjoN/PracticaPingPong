using PingPong.Domain.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Ping
{
    class PingServices : IPingServices
    {
        private event EventHandler _onReceiveMessage;

        public EventHandler OnReceiveMessage
        {
            get { return _onReceiveMessage; }
            set { _onReceiveMessage = value; }
        }

        public void PingSendMessage()
        {
            if (_onReceiveMessage != null)
            {
                _onReceiveMessage(new PingMessage("PING_MESSAGE"), null);
            }
        }
    }
}
