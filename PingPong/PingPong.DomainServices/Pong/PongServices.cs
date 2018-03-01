using PingPong.Domain.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Pong
{
    class PongServices: IPongServices
    {
        public event EventHandler OnReceiveMessage;

        public void PongSendMessage()
        {
            if (OnReceiveMessage != null)
            {
                OnReceiveMessage(new PongMessage("PONG_MESSAGE"), null);
            }
        }
    }
}
