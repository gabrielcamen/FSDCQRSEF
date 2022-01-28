using MediatR;
using Ninject;
using Ninject.Modules;

namespace SweetShop
{
    public class SweetShopBindingModule :  NinjectModule
    {
        public override void Load()
        {
            Bind<IMediator>().To<Mediator>().InSingletonScope();
            Bind<ServiceFactory>().ToMethod(ctx => t => ctx.Kernel.Get(t)).InSingletonScope();
        }
    }
}
