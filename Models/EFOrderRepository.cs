using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace TiệmSáchLongThành.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private TiệmSáchLongThànhDbContext context;
        public EFOrderRepository(TiệmSáchLongThànhDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders
        {
            get
            {
                return context.Orders
.Include(o => o.Lines)
.ThenInclude(l => l.Book);
            }
        }

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Book));
            if (order.OrderID == 0)
            {
                object p = context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}