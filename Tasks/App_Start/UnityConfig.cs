using System.Web.Http;
using Unity;
using Unity.WebApi;
using System.Web.Mvc;
using Tasks.Services;

namespace Tasks
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IStoreService, StoreService>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}