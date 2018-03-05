using PingPong.Domain.EventHandler;
using PingPong.Domain.PingPong;
using PingPong.DomainServices.Pong;
using PingPong.Infraestructure.MessageBroker;

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

        public PingPongMeasure PongMeassures()
        {
            return domainService.PongMeassures();
        }
    }
}
