using System.Collections.Generic;
using TiệmSáchLongThành.Models;
using TiệmSáchLongThành.Models.ViewModels;

namespace Tiệm_Sách_Long_Thành.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}