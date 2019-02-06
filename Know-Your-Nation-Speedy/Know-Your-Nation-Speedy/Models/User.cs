using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string MembershipType { get; set; }

        public ICollection<ArticlesRead> articlesRead { get; set; }
        public ICollection<BooksRead> booksReads { get; set; }
        public ICollection<ComicsRead> comicsReads { get; set; }
        public ICollection<AnimationsWatched> animationsWatched { get; set; }
        public ICollection<Donation> donations { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<UserEvents> userEvents { get; set; }

    }
}
