﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Serverland.Data;

#nullable disable

namespace Serverland.Migrations
{
    [DbContext(typeof(ServerDbContext))]
    [Migration("20241021093226_SeedServers")]
    partial class SeedServers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Serverland.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Manifacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServerType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Serverland.Data.Entities.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HDD")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Network")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PSU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Raid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Rails")
                        .HasColumnType("boolean");

                    b.Property<string>("SSD")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("serverId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Serverland.Data.Entities.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Disk_Count")
                        .HasColumnType("integer");

                    b.Property<string>("Generation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OS")
                        .HasColumnType("boolean");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.Property<int>("categoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Disk_Count = 2,
                            Generation = "ugXGzF",
                            Model = "Hdzl5a8hdf6",
                            OS = true,
                            Weight = 12.5,
                            categoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Disk_Count = 4,
                            Generation = "GenX",
                            Model = "Xyz5000",
                            OS = false,
                            Weight = 18.699999999999999,
                            categoryId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}