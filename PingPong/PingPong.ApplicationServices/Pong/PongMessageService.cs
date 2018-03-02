using PingPong.Domain.EventHandler;
using PingPong.DomainServices.Ping;
using PingPong.DomainServices.Pong;
using PingPong.Infraestructure.MessageBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ApplicationServices.Pong
{
    class PongMessageService : IPongMessageService
    {
        IPongServices domainService;
        ICommunicationHandler communicationHandler;

        public PongMessageService(IPongServices service, ICommunicationHandler communication)
        {
            domainService = service;
            communicationHandler = communication;
            domainService.OnMessageStarted += new MessageEventHandler(communicationHandler.SendMessage);
            communicationHandler.OnMessageArrived += new MessageArriveHandler(domainService.PongMessageReceived);
            communicationHandler.ReceiveMessage("pingpongQueue");
        }

        public string PongMeassures()
        {
            return domainService.PongMeassures();
        }
    }
}
