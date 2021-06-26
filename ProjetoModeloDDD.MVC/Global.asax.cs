using Ninject;
using Ninject.Modules;
using ProjetoModeloDDD.MVC.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Web.Common.WebHost;
using ProjetoModeloDDD.CrossCutting.IoC.Modulos;

namespace ProjetoModeloDDD.MVC
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMapping();
        }
        protected override IKernel CreateKernel()
        {
            var modules = new NinjectModule[] { new ModulosNinject() };
            return new StandardKernel(modules);
        }
    }
}
