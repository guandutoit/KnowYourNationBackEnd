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

        public DbSet<Users> UsersEntries { get; set; }
        public DbSet<Donations> DonationsEntries { get; set; }
        public DbSet<UserEvents> VolunteerEntries { get; set; }
        public DbSet<Events> EventsEntries { get; set; }
        public DbSet<Books> BooksEntries { get; set; }
        public DbSet<Comics> ComicsEntries { get; set; }
        public DbSet<Animations> AnimationsEntries { get; set; }
        public DbSet<Articles> ArticlesEntries { get; set; }
        public DbSet<BooksRead> BooksReadEntries { get; set; }
        public DbSet<ComicsRead> ComicsReadEntries { get; set; }
        public DbSet<AnimationsWatched> AnimationsWatchedEntries { get; set; }
        public DbSet<ArticlesRead> ArticlesReadEntries { get; set; }
        public DbSet<Orders> OrdersEntries { get; set; }
        public DbSet<Products> ProductsEntries { get; set; }
        public DbSet<ProductOrders> ProductOrdersEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationsWatched>()
                .HasKey(aw => new { aw.UsersId, aw.AnimationsId });
            modelBuilder.Entity<AnimationsWatched>()
                .HasOne(aw => aw.Animation)
                .WithMany(a => a.AnimationWatched)
                .HasForeignKey(aw => aw.AnimationsId);
            modelBuilder.Entity<AnimationsWatched>()
                .HasOne(aw => aw.User)
                .WithMany(a => a.AnimationWatched)
                .HasForeignKey(aw => aw.UsersId);

            modelBuilder.Entity<ArticlesRead>()
                .HasKey(ar => new { ar.UsersId, ar.ArticlesId });
            modelBuilder.Entity<ArticlesRead>()
                .HasOne(ar => ar.Article)
                .WithMany(a => a.ArticleRead)
                .HasForeignKey(ar => ar.ArticlesId);
            modelBuilder.Entity<ArticlesRead>()
                .HasOne(ar => ar.User)
                .WithMany(a => a.ArticleRead)
                .HasForeignKey(ar => ar.UsersId);

            modelBuilder.Entity<BooksRead>()
                .HasKey(br => new { br.UsersId, br.BooksId });
            modelBuilder.Entity<BooksRead>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BookRead)
                .HasForeignKey(br => br.BooksId);
            modelBuilder.Entity<BooksRead>()
                .HasOne(br => br.User)
                .WithMany(b => b.BookRead)
                .HasForeignKey(br => br.UsersId);

            modelBuilder.Entity<ComicsRead>()
                .HasKey(cr => new { cr.UsersId, cr.ComicsId });
            modelBuilder.Entity<ComicsRead>()
                .HasOne(cr => cr.Comic)
                .WithMany(c => c.ComicRead)
                .HasForeignKey(cr => cr.ComicsId);
            modelBuilder.Entity<ComicsRead>()
                .HasOne(cr => cr.User)
                .WithMany(c => c.ComicRead)
                .HasForeignKey(cr => cr.UsersId);

            modelBuilder.Entity<ProductOrders>()
                .HasKey(po => new { po.OrdersId, po.ProductsId });
            modelBuilder.Entity<ProductOrders>()
                .HasOne(po => po.Product)
                .WithMany(p => p.ProductOrder)
                .HasForeignKey(po => po.ProductsId);
            modelBuilder.Entity<ProductOrders>()
                .HasOne(po => po.Order)
                .WithMany(o => o.ProductOrder)
                .HasForeignKey(po => po.OrdersId);

            modelBuilder.Entity<UserEvents>()
                .HasKey(ue => new { ue.UsersId, ue.EventsId });
            modelBuilder.Entity<UserEvents>()
                .HasOne(ue => ue.Event)
                .WithMany(u => u.UserEvent)
                .HasForeignKey(ue => ue.EventsId);
            modelBuilder.Entity<UserEvents>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserEvent)
                .HasForeignKey(ue => ue.UsersId);

            modelBuilder.Entity<Users>()
           .HasMany(c => c.Order)
           .WithOne(e => e.User);

            modelBuilder.Entity<Users>()
           .HasMany(c => c.Donation)
           .WithOne(e => e.User);


        }

    }
}
