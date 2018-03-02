using PingPong.Domain.Contract;
using PingPong.Domain.EventHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Infraestructure.MessageBroker
{
    public interface ICommunicationHandler
    {
        MessageArriveHandler OnMessageArrived { get; set; }
        void SendMessage(IMessage message, string queue);
        void ReceiveMessage(string queue);
    }
}
