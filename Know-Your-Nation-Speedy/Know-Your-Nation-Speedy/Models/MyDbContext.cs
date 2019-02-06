using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public DbSet<User> UserEntries { get; set; }
        public DbSet<Donation> DonationEntries { get; set; }
        public DbSet<UserEvents> VolunteerEntries { get; set; }
        public DbSet<Events> EventEntries { get; set; }
        public DbSet<Book> BookEntries { get; set; }
        public DbSet<Comic> ComicEntries { get; set; }
        public DbSet<Animation> AnimationEntries { get; set; }
        public DbSet<Article> ArticlesEntries { get; set; }
        public DbSet<BooksRead> BooksReadEntries { get; set; }
        public DbSet<ComicsRead> ComicsReadEntries { get; set; }
        public DbSet<AnimationsWatched> AnimationsWatchedEntries { get; set; }
        public DbSet<ArticlesRead> ArticlesReadEntries { get; set; }
        public DbSet<Order> OrdersEntries { get; set; }
        public DbSet<Product> ProductEntries { get; set; }
        public DbSet<ProductOrders> ProductOrdersEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationsWatched>()
                .HasKey(aw => new { aw.UserId, aw.AnimationId });
            modelBuilder.Entity<AnimationsWatched>()
                .HasOne(aw => aw.animation)
                .WithMany(a => a.animationsWatched)
                .HasForeignKey(aw => aw.AnimationId);
            modelBuilder.Entity<AnimationsWatched>()
                .HasOne(aw => aw.user)
                .WithMany(a => a.animationsWatched)
                .HasForeignKey(aw => aw.UserId);

            modelBuilder.Entity<ArticlesRead>()
                .HasKey(ar => new { ar.UserId, ar.ArticleId });
            modelBuilder.Entity<ArticlesRead>()
                .HasOne(ar => ar.articles)
                .WithMany(a => a.articlesReads)
                .HasForeignKey(ar => ar.ArticleId);
            modelBuilder.Entity<ArticlesRead>()
                .HasOne(ar => ar.user)
                .WithMany(a => a.articlesRead)
                .HasForeignKey(ar => ar.UserId);

            modelBuilder.Entity<BooksRead>()
                .HasKey(br => new { br.UserId, br.BookId });
            modelBuilder.Entity<BooksRead>()
                .HasOne(br => br.book)
                .WithMany(b => b.booksReads)
                .HasForeignKey(br => br.BookId);
            modelBuilder.Entity<BooksRead>()
                .HasOne(br => br.user)
                .WithMany(b => b.booksReads)
                .HasForeignKey(br => br.UserId);

            modelBuilder.Entity<ComicsRead>()
                .HasKey(cr => new { cr.UserId, cr.ComicId });
            modelBuilder.Entity<ComicsRead>()
                .HasOne(cr => cr.comic)
                .WithMany(c => c.comicsReads)
                .HasForeignKey(cr => cr.ComicId);
            modelBuilder.Entity<ComicsRead>()
                .HasOne(cr => cr.user)
                .WithMany(c => c.comicsReads)
                .HasForeignKey(cr => cr.UserId);

            modelBuilder.Entity<ProductOrders>()
                .HasKey(po => new { po.OrderId, po.ProductId });
            modelBuilder.Entity<ProductOrders>()
                .HasOne(po => po.product)
                .WithMany(p => p.productOrders)
                .HasForeignKey(po => po.ProductId);
            modelBuilder.Entity<ProductOrders>()
                .HasOne(po => po.orders)
                .WithMany(o => o.productOrders)
                .HasForeignKey(po => po.OrderId);

            modelBuilder.Entity<UserEvents>()
                .HasKey(ue => new { ue.UserId, ue.EventId });
            modelBuilder.Entity<UserEvents>()
                .HasOne(ue => ue.events)
                .WithMany(u => u.userEvents)
                .HasForeignKey(ue => ue.EventId);
            modelBuilder.Entity<UserEvents>()
                .HasOne(ue => ue.user)
                .WithMany(u => u.userEvents)
                .HasForeignKey(ue => ue.UserId);

            modelBuilder.Entity<User>()
           .HasMany(c => c.orders)
           .WithOne(e => e.user);

            modelBuilder.Entity<User>()
           .HasMany(c => c.donations)
           .WithOne(e => e.user);


        }

    }
}
