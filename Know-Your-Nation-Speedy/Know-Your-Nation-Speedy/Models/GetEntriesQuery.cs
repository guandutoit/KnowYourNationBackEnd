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

        public IList<Animation> AnimationExecute()
        {
            return _db.AnimationEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<Article> ArticlesExecute()
        {
            return _db.ArticlesEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<Book> BookExecute()
        {
            return _db.BookEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<Comic> ComicExecute()
        {
            return _db.ComicEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<Donation> DonationExecute()
        {
            return _db.DonationEntries.OrderBy(e => e.Organization).ToList();
        }
        public IList<Events> EventExecute()
        {
            return _db.EventEntries.OrderBy(e => e.ProjectName).ToList();
        }
        public IList<Order> OrderExecute()
        {
            return _db.OrdersEntries.OrderBy(e => e.TrackingNumber).ToList();
        }
        public IList<Product> ProductExecute()
        {
            return _db.ProductEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<User> UserExecute()
        {
            return _db.UserEntries.OrderBy(e => e.Name).ToList();
        }
    }
}
