﻿// <auto-generated />
using DinhXuanCuong_0879_2425_BaiThi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DinhXuanCuong_0879_2425_BaiThi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250103015010_employee")]
    partial class employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DinhXuanCuong_0879_2425_BaiThi.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DinhXuanCuong_0879_2425_BaiThi.Models.Employee", b =>
                {
                    b.HasBaseType("DinhXuanCuong_0879_2425_BaiThi.Models.Person");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
