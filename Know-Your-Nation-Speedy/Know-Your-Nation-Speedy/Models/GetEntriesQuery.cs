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
        public IList<AnimationsWatched> AnimationsWatchedExecute()
        {
            return _db.AnimationsWatchedEntries.OrderBy(e => e.animation).ToList();
        }
        public IList<Article> ArticlesExecute()
        {
            return _db.ArticlesEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<ArticlesRead> ArticlesReadExecute()
        {
            return _db.ArticlesReadEntries.OrderBy(e => e.articles).ToList();
        }
        public IList<Book> BookExecute()
        {
            return _db.BookEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<BooksRead> BooksReadExecute()
        {
            return _db.BooksReadEntries.OrderBy(e => e.book).ToList();
        }
        public IList<Comic> ComicExecute()
        {
            return _db.ComicEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<ComicsRead> ComicsReadExecute()
        {
            return _db.ComicsReadEntries.OrderBy(e => e.comic).ToList();
        }
        public IList<Donation> DonationExecute()
        {
            return _db.DonationEntries.OrderBy(e => e.DonationId).ToList();
        }
        public IList<Order> OrdersExecute()
        {
            return _db.OrdersEntries.OrderBy(e => e.OrderId).ToList();
        }
        public IList<Product> ProductExecute()
        {
            return _db.ProductEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<ProductOrders> ProductOrdersExecute()
        {
            return _db.ProductOrdersEntries.OrderBy(e => e.orders).ToList();
        }
        public IList<User> UserExecute()
        {
            return _db.UserEntries.OrderBy(e => e.Name).ToList();
        }
        public IList<UserEvents> VolunteerExecute()
        {
            return _db.VolunteerEntries.OrderBy(e => e.events).ToList();
        }
        public IList<Events> VolunteerEventsExecute()
        {
            return _db.VolunteerEventEntries.OrderBy(e => e.ProjectName).ToList();
        }

    }
}
