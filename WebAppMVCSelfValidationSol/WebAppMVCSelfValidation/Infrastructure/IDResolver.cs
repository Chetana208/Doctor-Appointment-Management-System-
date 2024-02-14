using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCSelfValidation.Models.Abstract;
using WebAppMVCSelfValidation.Models.Concrete;

namespace WebAppMVCSelfValidation.Infrastructure
{
    public class IDResolver : IDependencyResolver
    {
        IKernel kernel;


        public IDResolver()
        {
            kernel = new StandardKernel();
            kernel.Bind<IAppointment>().To<FakeRepo>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}