using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoxData.Entities
{
    public partial class Context : DbContext
    {
        public Context() 
        {
        }
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Server=tcp:pizzaboxlieser.database.windows.net,1433;Initial Catalog=PizzaBoxDb;User ID=dev;Password=Password123");
            }
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");
           
                entity.Property(e => e.Summary)
                    .HasColumnType("text")
                    .HasColumnName("summary");

                entity.Property(e => e.TimeReceived)
                    .HasColumnType("datetime")
                    .HasColumnName("timeReceived");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID");

            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store");

                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("storeID");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                 .HasColumnName("UserName");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserPhone"); ;
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
