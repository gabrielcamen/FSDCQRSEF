using System.Collections.Generic;
using MediatR;
using Ninject.Modules;
using SweetShop.CQRS.Queries;
using SweetShop.DataAcces.Models;
using ICommand = System.Windows.Input.ICommand;

namespace SweetShop.CQRS
{
    public class CQRSBindingModule :  NinjectModule
    {
        public override void Load()
        {
            Bind<IQuery>().To<Query>();
            
            Bind<IUserNotificationHandler,
                    INotificationHandler<UserNotification>>()
                .To<AddNewUserCommand>();

            Bind<IGetAllUsersQuery,
                IRequestHandler<GetAllUsersQueryNotification, List<Client>>>()
                .To<GetAllUsersQuery>();
        }
    }
}
