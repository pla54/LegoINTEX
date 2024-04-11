namespace LegoINTEX.Models
{
    public class EFLegoINTEXRespository : ILegoINTEXRepository
    {
        private IntexiiContext _context;
        public EFLegoINTEXRespository(IntexiiContext temp)
        {
            _context = temp;
        }
        public IQueryable<Order> Orders => _context.Orders;
    }
}
