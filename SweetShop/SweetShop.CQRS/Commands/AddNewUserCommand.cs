using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SweetShop.DataAcces;

namespace SweetShop.CQRS
{
    public interface IUserNotificationHandler : INotificationHandler<UserNotification>
    {
        
    }

    public class AddNewUserCommand : IUserNotificationHandler 
    {
        public Task Handle(UserNotification notification, CancellationToken cancellationToken)
        {
            var shop = new SweetShopDbContext();
            shop.Clients.Add(notification.Client);
            shop.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
