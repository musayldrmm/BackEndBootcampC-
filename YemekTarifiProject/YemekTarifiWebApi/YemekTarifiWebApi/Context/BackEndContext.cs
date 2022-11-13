
using YemekTarifiWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace YemekTarifiApp.Context
{
    public class BackEndContext : DbContext
    {
        public BackEndContext(DbContextOptions<BackEndContext>options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Comments)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.ClientNoAction);


            modelBuilder.Entity<Comment>()
           .HasOne<Product>(s => s.Product)
           .WithMany(g => g.Comments)
           .HasForeignKey(s => s.ProductId)
           .OnDelete(DeleteBehavior.ClientNoAction);


            modelBuilder.Entity<Product>()
           .HasOne<User>(s => s.User)
           .WithMany(g => g.Products)
           .HasForeignKey(s => s.UserId)
           .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
