using System.Web.Mvc; 
using Unity;
using Unity.Mvc5;

namespace template_mvc
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<IModelContext, ModelContext>();
            //container.RegisterType<IItemRepository, ItemRepository>();
            //container.RegisterType<IItemGroupRepository, ItemGroupRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}