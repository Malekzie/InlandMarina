﻿// <auto-generated />
using Marina.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marina.DataAccess.Migrations
{
    [DbContext(typeof(MarinaDbContext))]
    [Migration("20240717190402_add_username_password_and_seed_database")]
    partial class add_username_password_and_seed_database
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Marina.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Phoenix",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "Imasneekyboi",
                            Phone = "265-555-1212",
                            Username = "JoeMama"
                        },
                        new
                        {
                            ID = 2,
                            City = "Calgary",
                            FirstName = "Sara",
                            LastName = "Williams",
                            Password = "Itsyogurl",
                            Phone = "403-555-9585",
                            Username = "SaraNookie"
                        },
                        new
                        {
                            ID = 3,
                            City = "Kansas City",
                            FirstName = "Ken",
                            LastName = "Wong",
                            Password = "ChickenRiceNoodles",
                            Phone = "802-555-3214",
                            Username = "NothingKenGoWong"
                        });
                });

            modelBuilder.Entity("Marina.Models.Dock", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("ElectricalService")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("WaterService")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Dock");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ElectricalService = true,
                            Name = "Dock A",
                            WaterService = true
                        },
                        new
                        {
                            ID = 2,
                            ElectricalService = false,
                            Name = "Dock B",
                            WaterService = true
                        },
                        new
                        {
                            ID = 3,
                            ElectricalService = true,
                            Name = "Dock C",
                            WaterService = false
                        });
                });

            modelBuilder.Entity("Marina.Models.Lease", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("SlipId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SlipId");

                    b.ToTable("Leases");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CustomerId = 1,
                            SlipId = 20
                        },
                        new
                        {
                            ID = 2,
                            CustomerId = 2,
                            SlipId = 42
                        },
                        new
                        {
                            ID = 3,
                            CustomerId = 3,
                            SlipId = 88
                        });
                });

            modelBuilder.Entity("Marina.Models.Slip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DockId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DockId");

                    b.ToTable("Slips");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 2,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 3,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 4,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 5,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 6,
                            DockId = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 7,
                            DockId = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 8,
                            DockId = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 9,
                            DockId = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 10,
                            DockId = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 11,
                            DockId = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 12,
                            DockId = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 13,
                            DockId = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 14,
                            DockId = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 15,
                            DockId = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 16,
                            DockId = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 17,
                            DockId = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 18,
                            DockId = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 19,
                            DockId = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 20,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 21,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 22,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 23,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 24,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 25,
                            DockId = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 26,
                            DockId = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 27,
                            DockId = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 28,
                            DockId = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 29,
                            DockId = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 30,
                            DockId = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 31,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 32,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 33,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 34,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 35,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 36,
                            DockId = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 37,
                            DockId = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 38,
                            DockId = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 39,
                            DockId = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 40,
                            DockId = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 41,
                            DockId = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 42,
                            DockId = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 43,
                            DockId = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 44,
                            DockId = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 45,
                            DockId = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 46,
                            DockId = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 47,
                            DockId = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 48,
                            DockId = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 49,
                            DockId = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 50,
                            DockId = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 51,
                            DockId = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 52,
                            DockId = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 53,
                            DockId = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 54,
                            DockId = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 55,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 56,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 57,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 58,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 59,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 60,
                            DockId = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 61,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 62,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 63,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 64,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 65,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 66,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 67,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 68,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 69,
                            DockId = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 70,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 71,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 72,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 73,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 74,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 75,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 76,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 77,
                            DockId = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 78,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 79,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 80,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 81,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 82,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 83,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 84,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 85,
                            DockId = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 86,
                            DockId = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 87,
                            DockId = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 88,
                            DockId = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 89,
                            DockId = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 90,
                            DockId = 3,
                            Length = 32,
                            Width = 12
                        });
                });

            modelBuilder.Entity("Marina.Models.Lease", b =>
                {
                    b.HasOne("Marina.Models.Customer", "Customer")
                        .WithMany("Leases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marina.Models.Slip", "Slip")
                        .WithMany("Leases")
                        .HasForeignKey("SlipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Slip");
                });

            modelBuilder.Entity("Marina.Models.Slip", b =>
                {
                    b.HasOne("Marina.Models.Dock", "Dock")
                        .WithMany("Slips")
                        .HasForeignKey("DockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dock");
                });

            modelBuilder.Entity("Marina.Models.Customer", b =>
                {
                    b.Navigation("Leases");
                });

            modelBuilder.Entity("Marina.Models.Dock", b =>
                {
                    b.Navigation("Slips");
                });

            modelBuilder.Entity("Marina.Models.Slip", b =>
                {
                    b.Navigation("Leases");
                });
#pragma warning restore 612, 618
        }
    }
}
