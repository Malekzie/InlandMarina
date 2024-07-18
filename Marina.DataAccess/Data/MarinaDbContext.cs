using Marina.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marina.DataAccess.Data
{
    public class MarinaDbContext : IdentityDbContext
    {
        public MarinaDbContext(DbContextOptions<MarinaDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Dock> Dock { get; set; }
        public DbSet<Slip> Slips { get; set; }
        public DbSet<Lease> Leases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lease>()
                          .HasOne(l => l.Customer)
                          .WithMany(c => c.Leases)
                          .HasForeignKey(l => l.CustomerID);

            var hasher = new PasswordHasher<IdentityUser>();

            var user1 = new IdentityUser
            {
                Id = "user1_id",
                UserName = "john.doe@example.com",
                NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
                Email = "john.doe@example.com",
                NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!")
            };

            var user2 = new IdentityUser
            {
                Id = "user2_id",
                UserName = "sara.williams@example.com",
                NormalizedUserName = "SARA.WILLIAMS@EXAMPLE.COM",
                Email = "sara.williams@example.com",
                NormalizedEmail = "SARA.WILLIAMS@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!")
            };

            var user3 = new IdentityUser
            {
                Id = "user3_id",
                UserName = "ken.wong@example.com",
                NormalizedUserName = "KEN.WONG@EXAMPLE.COM",
                Email = "ken.wong@example.com",
                NormalizedEmail = "KEN.WONG@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!")
            };

            modelBuilder.Entity<IdentityUser>().HasData(user1, user2, user3);

            modelBuilder.Entity<Dock>().HasData(
                new Dock { ID = 1, Name = "Dock A", WaterService = true, ElectricalService = true },
                new Dock { ID = 2, Name = "Dock B", WaterService = true, ElectricalService = false },
                new Dock { ID = 3, Name = "Dock C", WaterService = false, ElectricalService = true }
            );

            modelBuilder.Entity<Slip>().HasData(
                new Slip { ID = 1, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 2, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 3, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 4, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 5, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 6, Width = 8, Length = 16, DockId = 1 },
                new Slip { ID = 7, Width = 8, Length = 20, DockId = 1 },
                new Slip { ID = 8, Width = 8, Length = 20, DockId = 1 },
                new Slip { ID = 9, Width = 8, Length = 20, DockId = 1 },
                new Slip { ID = 10, Width = 8, Length = 20, DockId = 1 },
                new Slip { ID = 11, Width = 8, Length = 20, DockId = 1 },
                new Slip { ID = 12, Width = 8, Length = 22, DockId = 1 },
                new Slip { ID = 13, Width = 8, Length = 22, DockId = 1 },
                new Slip { ID = 14, Width = 8, Length = 22, DockId = 1 },
                new Slip { ID = 15, Width = 8, Length = 22, DockId = 1 },
                new Slip { ID = 16, Width = 8, Length = 24, DockId = 1 },
                new Slip { ID = 17, Width = 8, Length = 24, DockId = 1 },
                new Slip { ID = 18, Width = 8, Length = 24, DockId = 1 },
                new Slip { ID = 19, Width = 8, Length = 24, DockId = 1 },
                new Slip { ID = 20, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 21, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 22, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 23, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 24, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 25, Width = 8, Length = 26, DockId = 1 },
                new Slip { ID = 26, Width = 8, Length = 28, DockId = 1 },
                new Slip { ID = 27, Width = 8, Length = 28, DockId = 1 },
                new Slip { ID = 28, Width = 8, Length = 28, DockId = 1 },
                new Slip { ID = 29, Width = 8, Length = 28, DockId = 1 },
                new Slip { ID = 30, Width = 8, Length = 28, DockId = 1 },
                 new Slip { ID = 31, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 32, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 33, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 34, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 35, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 36, Width = 8, Length = 18, DockId = 2 },
                new Slip { ID = 37, Width = 8, Length = 20, DockId = 2 },
                new Slip { ID = 38, Width = 8, Length = 20, DockId = 2 },
                new Slip { ID = 39, Width = 8, Length = 20, DockId = 2 },
                new Slip { ID = 40, Width = 8, Length = 22, DockId = 2 },
                new Slip { ID = 41, Width = 8, Length = 22, DockId = 2 },
                new Slip { ID = 42, Width = 8, Length = 22, DockId = 2 },
                new Slip { ID = 43, Width = 8, Length = 24, DockId = 2 },
                new Slip { ID = 44, Width = 8, Length = 24, DockId = 2 },
                new Slip { ID = 45, Width = 8, Length = 24, DockId = 2 },
                new Slip { ID = 46, Width = 8, Length = 24, DockId = 2 },
                new Slip { ID = 47, Width = 8, Length = 28, DockId = 2 },
                new Slip { ID = 48, Width = 8, Length = 28, DockId = 2 },
                new Slip { ID = 49, Width = 8, Length = 28, DockId = 2 },
                new Slip { ID = 50, Width = 8, Length = 30, DockId = 2 },
                new Slip { ID = 51, Width = 8, Length = 30, DockId = 2 },
                new Slip { ID = 52, Width = 8, Length = 30, DockId = 2 },
                new Slip { ID = 53, Width = 8, Length = 30, DockId = 2 },
                new Slip { ID = 54, Width = 8, Length = 30, DockId = 2 },
                new Slip { ID = 55, Width = 8, Length = 32, DockId = 2 },
                new Slip { ID = 56, Width = 8, Length = 32, DockId = 2 },
                new Slip { ID = 57, Width = 8, Length = 32, DockId = 2 },
                new Slip { ID = 58, Width = 8, Length = 32, DockId = 2 },
                new Slip { ID = 59, Width = 8, Length = 32, DockId = 2 },
                new Slip { ID = 60, Width = 8, Length = 32, DockId = 2 },
                 new Slip { ID = 61, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 62, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 63, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 64, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 65, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 66, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 67, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 68, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 69, Width = 10, Length = 22, DockId = 3 },
                new Slip { ID = 70, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 71, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 72, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 73, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 74, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 75, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 76, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 77, Width = 10, Length = 24, DockId = 3 },
                new Slip { ID = 78, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 79, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 80, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 81, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 82, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 83, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 84, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 85, Width = 12, Length = 28, DockId = 3 },
                new Slip { ID = 86, Width = 12, Length = 32, DockId = 3 },
                new Slip { ID = 87, Width = 12, Length = 32, DockId = 3 },
                new Slip { ID = 88, Width = 12, Length = 32, DockId = 3 },
                new Slip { ID = 89, Width = 12, Length = 32, DockId = 3 },
                new Slip { ID = 90, Width = 12, Length = 32, DockId = 3 }
            );

            modelBuilder.Entity<Lease>().HasData(
                new Lease { ID = 1, SlipId = 20, CustomerID = "user1_id" },
                new Lease { ID = 2, SlipId = 42, CustomerID = "user2_id" },
                new Lease { ID = 3, SlipId = 88, CustomerID = "user3_id" }
            );
        }
    }
}
