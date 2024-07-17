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
    [Migration("20240717031609_init")]
    partial class init
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

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
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

                    b.ToTable("Docks");
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
