﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Chapter09Listings.TwoDbContexts;

namespace Test.Chapter09Listings.TwoDbContexts.Migration2
{
    [DbContext(typeof(DbContext2))]
    partial class DbContext2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Test.Chapter09Listings.TwoDbContexts.OnlyIn2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("OnlyIn2s");
                });

            modelBuilder.Entity("Test.Chapter09Listings.TwoDbContexts.Shared", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SharedString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToView("Shared");
                });
#pragma warning restore 612, 618
        }
    }
}
