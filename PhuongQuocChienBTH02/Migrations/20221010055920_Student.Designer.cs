﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PhuongQuocChienBTH02.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20221010055920_Student")]
    partial class Student
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("PhuongQuocChienBTH02.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Studentname")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}