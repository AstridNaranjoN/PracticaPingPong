using PingPong.ApplicationServices.Utils;
using PingPong.Infraestructure.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity.WebApi;

namespace PingPong.RestApi.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            RegisterTypes.RegisterApplicationTypes();
            var container = DependencyFactory.Container;

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}