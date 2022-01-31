using MediatR;
using SweetShop.DataAcces.Models;

namespace SweetShop.CQRS.Commands
{
    public class ClientNotification : INotification
    { 
        public Client Client { get; }

        public ClientNotification(Client client)
        {
            Client = client;
        }
    }
}
