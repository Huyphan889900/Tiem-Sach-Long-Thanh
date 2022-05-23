using System;
using System.Collections.Generic;
using System.Linq;

namespace TiệmSáchLongThành.Models
{
    internal class TiệmSáchLongThànhDbContext
    {
        public object Books { get; internal set; }
        public object Database { get; internal set; }
        public object Orders { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void AttachRange(IEnumerable<Book> enumerable)
        {
            throw new NotImplementedException();
        }

        internal class EFTiệmSáchLongThànhRepository
        {
            public IQueryable<Book> Books { get; internal set; }

            public static implicit operator EFTiệmSáchLongThànhRepository(TiệmSáchLongThànhDbContext v)
            {
                throw new NotImplementedException();
            }
        }
    }
}