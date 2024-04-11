namespace LegoINTEX.Models
{
    public interface ILegoINTEXRepository
    {
        public IQueryable<Order> Orders { get; }
    }
}
