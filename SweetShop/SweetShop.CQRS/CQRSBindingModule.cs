using MediatR;
using Ninject.Modules;
using SweetShop.CQRS.Commands;
using SweetShop.CQRS.Queries;
using ICommand = System.Windows.Input.ICommand;

namespace SweetShop.CQRS
{
    public class CQRSBindingModule :  NinjectModule
    {
        public override void Load()
        {
            Bind<ICQRSCommand>().To<CQRSCommand>();
            Bind<IQuery>().To<Query>();
            
            Bind<IUserNotificationHandler,
                    INotificationHandler<UserNotification>>()
                .To<UserNotificationHandler>();
        }
    }
}
