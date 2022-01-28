using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SweetShop.CQRS
{
    public interface IUserNotificationHandler : INotificationHandler<UserNotification>
    {
        
    }

    public class UserNotificationHandler : IUserNotificationHandler 
    {
        public Task Handle(UserNotification notification, CancellationToken cancellationToken)
        {
            var dd = notification.Client.FirstName;
            

            return Task.CompletedTask;
        }
    }
}
