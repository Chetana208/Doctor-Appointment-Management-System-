using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCDatavalidationMetadata.Models.Abstract;
using WebAppMVCDatavalidationMetadata.Models.Concrete;

namespace WebAppMVCDatavalidationMetadata.Infrastructure
{
    public class DIResolver : IDependencyResolver
    {
        IKernel kernel;
        public DIResolver()
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