using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy.Models
{
    public class GetEntriesQuery
    {
        private readonly MyDbContext _db;
        public GetEntriesQuery(MyDbContext db)
        {
            _db = db;
        }

        public IList<Entry> Execute()
        {
            return _db.Entries.OrderBy(e => e.Name).ToList();
        }
    }
}
