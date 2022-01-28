using MediatR;
using SweetShop.DataAcces.Models;

namespace SweetShop.CQRS
{
    public class UserNotification : INotification
    { 
        public Client Client { get; }

        public UserNotification(Client client)
        {
            Client = client;
        }
    }
}
