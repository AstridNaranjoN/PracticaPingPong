using PingPong.Domain.EventHandler;
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
        ICommunicationHandler communicationHandler;
        public PingMessageService(IPingServices service, ICommunicationHandler communication)
        {
            domainService = service;
            communicationHandler = communication;
            domainService.OnMessageStarted += new MessageEventHandler(communicationHandler.SendMessage);
            communicationHandler.OnMessageArrived += new MessageArriveHandler(domainService.PingMessageReceived);
        }

        public async Task PingSendMessage()
        {
            Guid id = domainService.PingSendMessage();
            communicationHandler.ReceiveMessage(id.ToString());
            await domainService.WaitReply();
        }
    }
}
