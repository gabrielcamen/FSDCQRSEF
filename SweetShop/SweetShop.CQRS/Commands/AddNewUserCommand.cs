using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SweetShop.DataAcces;

namespace SweetShop.CQRS.Commands
{
    public interface IAddClientNotificationHandler : INotificationHandler<ClientNotification>
    {
        
    }

    public class AddNewClientCommand : IAddClientNotificationHandler 
    {
        public Task Handle(ClientNotification notification, CancellationToken cancellationToken)
        {
            var shop = new SweetShopDbContext();
            shop.Clients.Add(notification.Client);
            shop.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
