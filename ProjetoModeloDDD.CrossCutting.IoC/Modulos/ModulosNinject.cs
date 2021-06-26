using Ninject.Modules;
using ProjetoModelo.Infra.Data.Repositories;
using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;

namespace ProjetoModeloDDD.CrossCutting.IoC.Modulos
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IClienteRepository>().To<ClienteRepository>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IClienteService>().To<ClienteService>();

            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IClienteAppService>().To<ClienteAppService>();
        }
    }
}
