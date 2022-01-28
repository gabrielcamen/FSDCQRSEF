namespace SweetShop.CQRS.Queries
{
    public interface IQuery
    {
        string Name { get; set; }    
    }
    
    public class Query : IQuery
    {
        public string Name { get; set; } = "Marian";
    }
}
