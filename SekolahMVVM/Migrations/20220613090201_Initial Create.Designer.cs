﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SekolahMVVM.Models;

#nullable disable

namespace SekolahMVVM.Migrations
{
    [DbContext(typeof(SiswaDbContext))]
    [Migration("20220613090201_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SekolahMVVM.Models.Siswa", b =>
                {
                    b.Property<int>("IdSiswa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSiswa"), 1L, 1);

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GolonganDarah")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Hobi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomorHandphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinggiBadan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSiswa");

                    b.ToTable("Siswa");
                });
#pragma warning restore 612, 618
        }
    }
}
