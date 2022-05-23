using System.Linq;
using Tiệm_Sách_Long_Thành.Models;

namespace TiệmSáchLongThành.Models
{
    public interface ITiệmSáchLongThànhRepository
    {
        IQueryable<Book> Books { get; }
    }
}