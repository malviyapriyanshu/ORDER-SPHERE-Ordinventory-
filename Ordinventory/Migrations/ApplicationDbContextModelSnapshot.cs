﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ordinventory.Data;

#nullable disable

namespace Ordinventory.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ordinventory.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Condiments"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Confections"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Dairy Products"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Grains/Cereals"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Meat/Poultry"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Produce"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Seafood"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
