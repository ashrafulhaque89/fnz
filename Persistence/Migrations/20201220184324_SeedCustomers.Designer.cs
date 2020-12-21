﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201220184324_SeedCustomers")]
    partial class SeedCustomers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("First_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Last_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            First_name = "John",
                            Gender = "Male",
                            Last_name = "Munroe"
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(1990, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            First_name = "Danica",
                            Gender = "Female",
                            Last_name = "Blake"
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            First_name = "Monica",
                            Gender = "Female",
                            Last_name = "Sandy"
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            First_name = "Colm",
                            Gender = "Male",
                            Last_name = "Blair"
                        },
                        new
                        {
                            Id = 5,
                            DOB = new DateTime(1984, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            First_name = "Declan",
                            Gender = "Male",
                            Last_name = "Rowley"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
