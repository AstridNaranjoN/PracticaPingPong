using PingPong.DomainServices.Ping;
using PingPong.Infraestructure.MessageBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ApplicationServices.Ping
{
    class PingMessageService : IPingMessageService
    {
        IPingServices domainService;
        public PingMessageService(IPingServices service)
        {
            domainService = service;
        }

        public void PingSendMessage()
        {
            domainService.PingSendMessage();
            domainService.OnReceiveMessage += new EventHandler(Send.SendMessage);
        }
    }
}
