using Microsoft.EntityFrameworkCore;
using StorDatabase_3_1.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace StorDatabase_3_1.ApplicationDbcontexet
{
    internal class ApplicationDBstore : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-QRVEHH6A\\MSSQLSERVER01;Initial catalog = WHStore ;Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.UserId)
                          .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Store>().Property(w => w.CompanyId)
                .IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Company>().Property(z => z.CompanyName).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Review>()
                .Property(r => r.Rating)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Store>()
                .Property(s => s.price)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Booking>()
                .Property(b => b.Status)
                .HasMaxLength(50); // Adjust the length as needed

            modelBuilder.Entity<Notification>()
                .Property(n => n.NotificationType)
                .HasMaxLength(50); // Adjust the length as needed

            // Add other configurations as needed


        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}



