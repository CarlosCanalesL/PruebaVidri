﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaVidri.Data;

#nullable disable

namespace PruebaVidri.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaVidri.Entities.Hero", b =>
                {
                    b.Property<int>("HeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeroId"));

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("HeroId");

                    b.ToTable("Hero");

                    b.HasData(
                        new
                        {
                            HeroId = 1,
                            Alias = "The Dark Knight",
                            name = "Batman"
                        },
                        new
                        {
                            HeroId = 2,
                            Alias = "Friendly Neighbor",
                            name = "Spider-man"
                        },
                        new
                        {
                            HeroId = 3,
                            Alias = "The Fastest Man",
                            name = "Flash"
                        },
                        new
                        {
                            HeroId = 4,
                            Alias = "",
                            name = "Green Lantern"
                        },
                        new
                        {
                            HeroId = 5,
                            Alias = "God of Thunder",
                            name = "Thor"
                        },
                        new
                        {
                            HeroId = 6,
                            Alias = "The First Avenger",
                            name = "Captain America"
                        });
                });

            modelBuilder.Entity("PruebaVidri.Entities.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Power");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Exceptional deduction",
                            HeroId = 1,
                            Name = "Detective Skills"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hand-to-hand combat",
                            HeroId = 1,
                            Name = "Martials Arts"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Alerts to danger",
                            HeroId = 2,
                            Name = "Spider Sense"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Spins spider webs",
                            HeroId = 2,
                            Name = "Web-Shooting"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
