using PingPong.ApplicationServices.Ping;
using PingPong.ApplicationServices.Pong;
using PingPong.Domain.Repositories;
using PingPong.DomainServices.Ping;
using PingPong.DomainServices.Pong;
using PingPong.Infraestructure.Dependencies;
using PingPong.Infraestructure.MessageBroker;
using PingPong.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ApplicationServices.Utils
{
    public static class RegisterTypes
    {
        public static void RegisterApplicationTypes()
        {
            RegisterEntityRepositories();
            RegisterDomainServices();
            RegisterApplicationServices();
            RegisterInfraestructureService();
        }

        private static void RegisterEntityRepositories()
        {
            DependencyFactory.RegisterType<IPingRepository, PingRepository>();
            DependencyFactory.RegisterType<IPongRepository, PongRepository>();
        }

        private static void RegisterDomainServices()
        {
            DependencyFactory.RegisterType<IPingServices, PingServices>();
            DependencyFactory.RegisterType<IPongServices, PongServices>();
        }

        private static void RegisterApplicationServices()
        {
            DependencyFactory.RegisterType<IPingMessageService, PingMessageService>();
            //DependencyFactory.RegisterType<IPongMessageService, PongMessageService>();
            ICommunicationHandler comm = new MessageBrokerHandler();
            comm.ReceiveMessage("pingpongQueue");
            IPongMessageService servicePong = new PongMessageService(new PongServices(new PingRepository()), comm);
            DependencyFactory.RegisterInstance<IPongMessageService>(servicePong);


        }

        private static void RegisterInfraestructureService()
        {
            DependencyFactory.RegisterType<ICommunicationHandler, MessageBrokerHandler>();
        }
    }
}
