using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;


namespace EssentialTool.App_Start
{
    public class NinjectWebCommon
    {
        static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new EssentialTool.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}