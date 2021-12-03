using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BusinessLayer;

namespace DependencyInjectApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEmployee, Employee>(); //future any changes done here only.
            container.RegisterType<IStudent, Student>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}