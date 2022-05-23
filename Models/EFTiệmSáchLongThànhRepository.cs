using System.Linq;
namespace TiệmSáchLongThành.Models
{
    public class EFTiệmSáchLongThànhRepository : ITiệmSáchLongThànhRepository
    {
        private TiệmSáchLongThànhDbContext context;
        public EFTiệmSáchLongThànhRepository(TiệmSáchLongThànhDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
    }
}