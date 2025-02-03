﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiWithController.Persistence.EFCore.Data;

#nullable disable

namespace WebApiWithController.Persistence.EFCore.Migrations
{
    [DbContext(typeof(HeroDbContext))]
    partial class HeroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiWithController.Persistence.EFCore.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperHeroName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Steve Rogers",
                            SuperHeroName = "Captain America",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tony Stark",
                            SuperHeroName = "",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bruce Banner",
                            SuperHeroName = "Hulk",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thor Odinson",
                            SuperHeroName = "Thor",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Natasha Romanoff",
                            SuperHeroName = "Black Widow",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Clint Barton",
                            SuperHeroName = "Hawkeye",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Wanda Maximoff",
                            SuperHeroName = "Scarlet Witch",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Vision",
                            SuperHeroName = "",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 9,
                            Name = "James Rhodes",
                            SuperHeroName = "War Machine",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sam Wilson",
                            SuperHeroName = "Falcon",
                            Team = "Avengers"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Clark Kent",
                            SuperHeroName = "Superman",
                            Team = "Justice League"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Bruce Wayne",
                            SuperHeroName = "Batman",
                            Team = "Justice League"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
