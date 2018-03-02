using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace PingPong.Infraestructure.Dependencies
{
    public static class DependencyFactory
    {
        private static IUnityContainer _container;

        /// <summary>
        /// Public reference to the unity container which will 
        /// allow the ability to register instrances or take 
        /// other actions on the container.
        /// </summary>
        public static IUnityContainer Container
        {
            get
            {
                return _container;
            }
            private set
            {
                _container = value;
            }
        }

        /// <summary>
        /// Static constructor for DependencyFactory which will 
        /// initialize the unity container.
        /// </summary>
        static DependencyFactory()
        {
            var container = new UnityContainer();
            _container = container;
        }

        /// <summary>
        /// Resolves the type parameter T to an instance of the appropriate type.
        /// </summary>
        /// <typeparam name="T">Type of object to return</typeparam>
        public static T Resolve<T>()
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }

        public static void RegisterInstance<InterfaceType>(InterfaceType instance)
        {
            Container.RegisterInstance<InterfaceType>(instance);
        }

        public static void RegisterType<InterfaceType, ClassType>() where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>();
        }

        public static void RegisterTypeWithOneParameterConstructor<InterfaceType, ClassType>(string constructorParameterValue) where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>(new InjectionConstructor(constructorParameterValue));
        }

        public static void RegisterTypeWithOneParameterConstructorHierarchicalLifetimeManager<InterfaceType, ClassType>(string constructorParameterValue) where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>(new HierarchicalLifetimeManager(), new InjectionConstructor(constructorParameterValue));
        }

        public static void RegisterTypeWithTwoParameterConstructor<InterfaceType, ClassType, AdditionalParameterType>(string constructorParameterValue) where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>(new InjectionConstructor(constructorParameterValue, Resolve<AdditionalParameterType>()));
        }

        public static void RegisterTypeWithConstructor<InterfaceType, ClassType>(InjectionConstructor constructorInjection) where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>(constructorInjection);
        }
    }
}
