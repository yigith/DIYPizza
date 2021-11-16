﻿// <auto-generated />
using DIYPizza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DIYPizza.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20211116080815_Ilk")]
    partial class Ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DIYPizza.Models.Malzeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Malzemeler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Mozzarella Peyniri"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Pizza Sosu"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Mısır"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Zeytin"
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Salam"
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Sucuk"
                        },
                        new
                        {
                            Id = 7,
                            Ad = "Sosis"
                        },
                        new
                        {
                            Id = 8,
                            Ad = "Biber"
                        },
                        new
                        {
                            Id = 9,
                            Ad = "Mantar"
                        },
                        new
                        {
                            Id = 10,
                            Ad = "Pastırma"
                        },
                        new
                        {
                            Id = 11,
                            Ad = "Ananas"
                        },
                        new
                        {
                            Id = 12,
                            Ad = "Ton Balığı"
                        },
                        new
                        {
                            Id = 13,
                            Ad = "Rokfor Peyniri"
                        },
                        new
                        {
                            Id = 14,
                            Ad = "Kaşar Peyniri"
                        },
                        new
                        {
                            Id = 15,
                            Ad = "Kavurma"
                        },
                        new
                        {
                            Id = 16,
                            Ad = "Füme"
                        },
                        new
                        {
                            Id = 17,
                            Ad = "Soğan"
                        },
                        new
                        {
                            Id = 18,
                            Ad = "Tavuk"
                        },
                        new
                        {
                            Id = 19,
                            Ad = "Parmesan Peyniri"
                        },
                        new
                        {
                            Id = 20,
                            Ad = "Domates"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}