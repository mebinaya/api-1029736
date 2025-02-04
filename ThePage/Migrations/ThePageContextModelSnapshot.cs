﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThePage.Data;

#nullable disable

namespace ThePage.Migrations
{
    [DbContext(typeof(ThePageContext))]
    partial class ThePageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ThePage.Models.Shop", b =>
                {
                    b.Property<int>("Shop_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shop_Id"), 1L, 1);

                    b.Property<string>("Shop_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shop_Price")
                        .HasColumnType("int");

                    b.HasKey("Shop_Id");

                    b.ToTable("Shop");
                });
#pragma warning restore 612, 618
        }
    }
}
