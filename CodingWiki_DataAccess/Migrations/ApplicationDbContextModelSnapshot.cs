﻿// <auto-generated />
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodingWiki_Model.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            ISBN = "111U11",
                            Price = 10.99m,
                            Title = "THe Hobbit"
                        },
                        new
                        {
                            BookId = 2,
                            ISBN = "1S11U11",
                            Price = 25.99m,
                            Title = "Summarily"
                        },
                        new
                        {
                            BookId = 3,
                            ISBN = "XK12345",
                            Price = 12.99m,
                            Title = "The Wanderer's Tale"
                        },
                        new
                        {
                            BookId = 4,
                            ISBN = "YZ98765",
                            Price = 15.49m,
                            Title = "Mystery of the Night"
                        },
                        new
                        {
                            BookId = 5,
                            ISBN = "LM45678",
                            Price = 8.75m,
                            Title = "Journey to the Stars"
                        },
                        new
                        {
                            BookId = 6,
                            ISBN = "HG54321",
                            Price = 20.00m,
                            Title = "The Lost Kingdom"
                        },
                        new
                        {
                            BookId = 7,
                            ISBN = "TR65432",
                            Price = 18.99m,
                            Title = "Secrets of the Deep"
                        });
                });

            modelBuilder.Entity("CodingWiki_Model.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
