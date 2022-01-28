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

    public interface IGetAllUsersQueryNotification : IRequest<List<Client>>
    {
        
    }

    public class GetAllUsersQueryNotification : IGetAllUsersQueryNotification
    {
        
    }
    
    
    public interface IGetAllUsersQuery : IRequestHandler<IGetAllUsersQueryNotification, List<Client>>
    {
        
    }
    
    public class GetAllUsersQuery : IGetAllUsersQuery
    {
        public Task<List<Client>> Handle(IGetAllUsersQueryNotification notification, CancellationToken cancellationToken)
        {
            var database = new SweetShopDbContext();
            var clients = database.Clients.ToList();
            return database.Clients.ToListAsync(cancellationToken);
        }
    }
}
