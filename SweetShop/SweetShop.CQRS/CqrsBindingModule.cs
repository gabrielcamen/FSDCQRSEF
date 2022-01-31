using System.Collections.Generic;
using MediatR;
using Ninject.Modules;
using SweetShop.CQRS.Commands;
using SweetShop.DataAcces.Models;

namespace SweetShop.CQRS
{
    public class CqrsBindingModule :  NinjectModule
    {
        public override void Load()
        {
            Bind<IAddClientNotificationHandler,
                    INotificationHandler<ClientNotification>>()
                .To<AddNewClientCommand>();

            Bind<IGetAllClientsQuery,
                IRequestHandler<GetAllClientsQueryNotification, List<Client>>>()
                .To<GetAllClientsQuery>();
        }
    }
}
