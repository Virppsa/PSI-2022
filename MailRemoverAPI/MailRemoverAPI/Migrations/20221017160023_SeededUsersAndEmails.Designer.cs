﻿// <auto-generated />
using System;
using MailRemoverAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MailRemoverAPI.Migrations
{
    [DbContext(typeof(MailRemoverDbContext))]
    [Migration("20221017160023_SeededUsersAndEmails")]
    partial class SeededUsersAndEmails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("11f8ccf0-da8d-4cd1-87ee-a8255fbe7c47"),
                            Token = "b07f85be-45da",
                            Type = 0,
                            UserId = new Guid("84a338e2-6367-4ae0-a3b4-3ce35ff5d263")
                        },
                        new
                        {
                            Id = new Guid("c908ff39-f339-4d08-9ce0-692f1c62623f"),
                            Token = "a08885be-89da",
                            Type = 0,
                            UserId = new Guid("84a338e2-6367-4ae0-a3b4-3ce35ff5d263")
                        },
                        new
                        {
                            Id = new Guid("e07a141b-a661-4b23-958f-2d2ad80f62d3"),
                            Token = "b07f96be-45da",
                            Type = 0,
                            UserId = new Guid("8abf7776-f21f-4861-a7b0-ee1b007de08c")
                        },
                        new
                        {
                            Id = new Guid("2b105217-8a39-40bf-b0a2-2f0c27693024"),
                            Token = "b07f45be-45da",
                            Type = 0,
                            UserId = new Guid("1945e44d-1c70-4378-a8c3-097a49bf7dbb")
                        },
                        new
                        {
                            Id = new Guid("4b9f76fc-e828-4e68-aa27-272692e949a6"),
                            Token = "b07f75be-45da",
                            Type = 0,
                            UserId = new Guid("65d13da7-fe64-485a-999c-225b18351244")
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
                            Id = new Guid("84a338e2-6367-4ae0-a3b4-3ce35ff5d263"),
                            FirstName = "Tomas",
                            LastName = "Sinkevičius",
                            Password = "RjEUW1R58r"
                        },
                        new
                        {
                            Id = new Guid("8abf7776-f21f-4861-a7b0-ee1b007de08c"),
                            FirstName = "Greta",
                            LastName = "Virpšaitė",
                            Password = "@G3gng9t6XBe"
                        },
                        new
                        {
                            Id = new Guid("1945e44d-1c70-4378-a8c3-097a49bf7dbb"),
                            FirstName = "Austėja",
                            LastName = "Naujokaitė",
                            Password = "3Gcoj6!Z1bnc"
                        },
                        new
                        {
                            Id = new Guid("65d13da7-fe64-485a-999c-225b18351244"),
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
