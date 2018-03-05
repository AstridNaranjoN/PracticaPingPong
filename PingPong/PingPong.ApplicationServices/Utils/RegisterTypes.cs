using PingPong.ApplicationServices.Ping;
using PingPong.ApplicationServices.Pong;
using PingPong.Domain.Repositories;
using PingPong.DomainServices.Ping;
using PingPong.DomainServices.Pong;
using PingPong.Infraestructure.Dependencies;
using PingPong.Infraestructure.MessageBroker;
using PingPong.Infraestructure.Repositories;

namespace PingPong.ApplicationServices.Utils
{
    public static class RegisterTypes
    {
        public static void RegisterApplicationTypes()
        {
            RegisterEntityRepositories();
            RegisterDomainServices();
            RegisterInfraestructureService();
            //RegisterApplicationServices();
        }

        private static void RegisterEntityRepositories()
        {
            DependencyFactory.RegisterType<IPingRepository, PingRepository>();
            DependencyFactory.RegisterType<IPongRepository, PongRepository>();
            DependencyFactory.RegisterType<IUnitOfWork, UnitOfWork>();
        }

        private static void RegisterDomainServices()
        {
            DependencyFactory.RegisterType<IPingServices, PingServices>();
            DependencyFactory.RegisterType<IPongServices, PongServices>();
        }

        public static void RegisterPingApplicationServices()
        {
            DependencyFactory.RegisterType<IPingMessageService, PingMessageService>();
        }

        public static void RegisterPongApplicationServices()
        {
            DependencyFactory.RegisterType<IPongMessageService, PongMessageService>();
            var service = DependencyFactory.Container.Resolve(typeof(PongMessageService), "PongMessageService");
            DependencyFactory.RegisterInstance<IPongMessageService>((IPongMessageService)service);
        }

        private static void RegisterInfraestructureService()
        {
            DependencyFactory.RegisterType<ICommunicationHandler, MessageBrokerHandler>();
        }
    }
}
