using Autofac;
using Autofac.Integration.WebApi;
using BusinessLogicService.BusinessLogicService;
using BusinessLogicService.IBusinessLogicService;
using DataAccess.Providers.IRepository;
using DataAccess.Providers.Repository;
using exampleproject.Helpers;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace exampleproject.App_Start
{
    public class AutofacWebapiConfig
    {

        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerRequest();

            builder.RegisterType<CustomerBLS>().As<ICustomerBLS>().InstancePerRequest();
            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

    }

}