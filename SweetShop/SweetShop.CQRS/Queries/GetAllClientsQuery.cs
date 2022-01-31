using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SweetShop.DataAcces;
using SweetShop.DataAcces.Models;

namespace SweetShop.CQRS
{

    public interface IGetAllClientsQueryNotification : IRequest<List<Client>>
    {
        
    }

    public class GetAllClientsQueryNotification : IGetAllClientsQueryNotification
    {
        
    }
    
    
    public interface IGetAllClientsQuery : IRequestHandler<IGetAllClientsQueryNotification, List<Client>>
    {
        
    }
    
    public class GetAllClientsQuery : IGetAllClientsQuery
    {
        public Task<List<Client>> Handle(IGetAllClientsQueryNotification notification, CancellationToken cancellationToken)
        {
            var database = new SweetShopDbContext();
            var clients = database.Clients.ToList();
            return database.Clients.ToListAsync(cancellationToken);
        }
    }
}
