﻿// <auto-generated />
using System;
using MailRemoverAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MailRemoverAPI.Migrations
{
    [DbContext(typeof(MailRemoverDbContext))]
    partial class MailRemoverDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MailRemoverAPI.Entities.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3643d36c-3ea1-4bfd-b35f-21a3de71a8d0"),
                            Address = "1234user@gmail.com",
                            Token = "b07f85be-45da",
                            Type = 0,
                            UserId = new Guid("487d101f-ab59-42f2-839e-039b680667cb")
                        },
                        new
                        {
                            Id = new Guid("c8d69fc2-45d6-4112-b853-6f6c5cd7c498"),
                            Address = "1234wre2ruser@gmail.com",
                            Token = "a08885be-89da",
                            Type = 0,
                            UserId = new Guid("487d101f-ab59-42f2-839e-039b680667cb")
                        },
                        new
                        {
                            Id = new Guid("64f39d58-18a8-4e2d-a687-bc9fc8beb87a"),
                            Address = "rsdfe2ruser@gmail.com",
                            Token = "b07f96be-45da",
                            Type = 0,
                            UserId = new Guid("bb0b7544-c8ff-4f63-97c3-506962ca5b6e")
                        },
                        new
                        {
                            Id = new Guid("dd1e53db-2b4d-405f-99d8-5fb22549ce92"),
                            Address = "lunasuo@gmail.com",
                            Token = "b07f45be-45da",
                            Type = 0,
                            UserId = new Guid("a42e6f76-87a0-4c20-a48d-f14edd1eaaa8")
                        },
                        new
                        {
                            Id = new Guid("7634dd4d-43e1-4c12-8f28-728b378b2e6d"),
                            Address = "lapesuo@gmail.com",
                            Token = "b07f75be-45da",
                            Type = 0,
                            UserId = new Guid("b1fa4b39-d2d7-48d4-8719-3e692944468f")
                        });
                });

            modelBuilder.Entity("MailRemoverAPI.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("487d101f-ab59-42f2-839e-039b680667cb"),
                            FirstName = "Tomas",
                            LastName = "Sinkevičius",
                            Password = "RjEUW1R58r"
                        },
                        new
                        {
                            Id = new Guid("bb0b7544-c8ff-4f63-97c3-506962ca5b6e"),
                            FirstName = "Greta",
                            LastName = "Virpšaitė",
                            Password = "@G3gng9t6XBe"
                        },
                        new
                        {
                            Id = new Guid("a42e6f76-87a0-4c20-a48d-f14edd1eaaa8"),
                            FirstName = "Austėja",
                            LastName = "Naujokaitė",
                            Password = "3Gcoj6!Z1bnc"
                        },
                        new
                        {
                            Id = new Guid("b1fa4b39-d2d7-48d4-8719-3e692944468f"),
                            FirstName = "Benas",
                            LastName = "Skripkiūnas",
                            Password = "*Y4!3l710POq"
                        });
                });

            modelBuilder.Entity("MailRemoverAPI.Entities.Email", b =>
                {
                    b.HasOne("MailRemoverAPI.Entities.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MailRemoverAPI.Entities.User", b =>
                {
                    b.Navigation("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
