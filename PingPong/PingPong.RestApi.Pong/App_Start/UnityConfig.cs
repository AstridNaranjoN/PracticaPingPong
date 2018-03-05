using System.Web.Http;
using Unity;
using Unity.WebApi;
using PingPong.Infraestructure.Dependencies;
using PingPong.ApplicationServices.Utils;

namespace PingPong.RestApi.Pong
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            RegisterTypes.RegisterApplicationTypes();
            RegisterTypes.RegisterPongApplicationServices();
            var container = DependencyFactory.Container;
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}