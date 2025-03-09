﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Szamnegyes.Backend.Context;

#nullable disable

namespace Szamnegyes.Backend.Migrations
{
    [DbContext(typeof(FoursContext))]
    partial class FoursContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Szamnegyes.Shared.Models.Fours", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("A")
                        .HasColumnType("int");

                    b.Property<int>("B")
                        .HasColumnType("int");

                    b.Property<int>("C")
                        .HasColumnType("int");

                    b.Property<int>("D")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fours");

                    b.HasData(
                        new
                        {
                            Id = 1234,
                            A = 1,
                            B = 2,
                            C = 3,
                            D = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
