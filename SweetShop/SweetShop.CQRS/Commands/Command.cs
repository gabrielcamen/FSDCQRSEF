using SweetShop.CQRS.Queries;

namespace SweetShop.CQRS.Commands
{
    public interface ICQRSCommand
    {
        
    }
    
    public class CQRSCommand : ICQRSCommand
    {
        private readonly IQuery _query;

        public CQRSCommand(IQuery query)
        {
            _query = query;
        }
    }
}
