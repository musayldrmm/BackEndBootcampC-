using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiWebApi.Model;

namespace YemekTarifiApp.Context
{
    internal class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("Server=DESKTOP-99N5D12; Database=YemekTarifiDB; Trusted_Connection=True;")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasRequired<User>(s => s.User)
                .WithMany(g => g.Comments)
                .HasForeignKey<int>(s => s.UserId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Comment>()
           .HasRequired<Product>(s => s.Product)
           .WithMany(g => g.Comments)
           .HasForeignKey<int>(s => s.ProductId)
           .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
           .HasRequired<User>(s => s.User)
           .WithMany(g => g.Products)
           .HasForeignKey<int>(s => s.UserId)
           .WillCascadeOnDelete(false);
        }
    }
}
