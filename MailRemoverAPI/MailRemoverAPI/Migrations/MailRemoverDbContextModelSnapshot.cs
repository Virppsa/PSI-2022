﻿// <auto-generated />
using MailRemoverAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

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
                            Id = new Guid("858dc5b6-3073-4fe1-a6e8-506faf29b36c"),
                            Address = "1234user@gmail.com",
                            Token = "b07f85be-45da",
                            Type = 0,
                            UserId = new Guid("e02dcc2d-f5ef-4c1b-b75d-6027d5328d7e")
                        },
                        new
                        {
                            Id = new Guid("2f1a9b4b-f4e9-4cf0-a194-fe7bb8e37e50"),
                            Address = "1234wre2ruser@gmail.com",
                            Token = "a08885be-89da",
                            Type = 0,
                            UserId = new Guid("e02dcc2d-f5ef-4c1b-b75d-6027d5328d7e")
                        },
                        new
                        {
                            Id = new Guid("0922493f-dbc0-4a23-b5a5-2a233d369c99"),
                            Address = "rsdfe2ruser@gmail.com",
                            Token = "b07f96be-45da",
                            Type = 0,
                            UserId = new Guid("52dc0e28-6fcf-4b15-b323-8b46354d8008")
                        },
                        new
                        {
                            Id = new Guid("f0a55e3c-e284-4d43-898c-c3a208489cb6"),
                            Address = "lunasuo@gmail.com",
                            Token = "b07f45be-45da",
                            Type = 0,
                            UserId = new Guid("95d18f2d-1b08-49d9-a0da-9cd2ed0287ea")
                        },
                        new
                        {
                            Id = new Guid("1825c40a-1712-4a59-be14-e6a6d1f4ba4a"),
                            Address = "lapesuo@gmail.com",
                            Token = "b07f75be-45da",
                            Type = 0,
                            UserId = new Guid("c3ec3e62-48cc-40ea-b682-71262311e413")
                        });
                });

            modelBuilder.Entity("MailRemoverAPI.Entities.Gmail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Gmails");
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

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e02dcc2d-f5ef-4c1b-b75d-6027d5328d7e"),
                            FirstName = "Tomas",
                            LastName = "Sinkevičius",
                            Password = "$2a$10$T1/7sZdhm1jSx4n9F1oGTetCPjEB9jCWue9NFiWDM9yOYRMHY03IC",
                            UserEmail = "tomas.sinkevicius@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("52dc0e28-6fcf-4b15-b323-8b46354d8008"),
                            FirstName = "Greta",
                            LastName = "Virpšaitė",
                            Password = "$2a$10$qgynSeg0Dp9fbprj2b.REuSFWuPd7DoPOP5APhWYokQTWCxlgjYmG",
                            UserEmail = "greta.virpsaite@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("95d18f2d-1b08-49d9-a0da-9cd2ed0287ea"),
                            FirstName = "Austėja",
                            LastName = "Naujokaitė",
                            Password = "$2a$10$aF0xgR8qHekS3nmTFalK4uxQoLsiZvcIFa4KtwMdjvxHKZTzXqyiC",
                            UserEmail = "austeja.naujokaite@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("c3ec3e62-48cc-40ea-b682-71262311e413"),
                            FirstName = "Benas",
                            LastName = "Skripkiūnas",
                            Password = "$2a$10$m99AxXOwEiOgOj4I49an8uMLBqOBiFxrDanTHMmViMTGiotWAKhma",
                            UserEmail = "benas.skripkunas@gmail.com"
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

            modelBuilder.Entity("MailRemoverAPI.Entities.Gmail", b =>
                {
                    b.HasOne("MailRemoverAPI.Entities.User", "User")
                        .WithMany("Gmails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MailRemoverAPI.Entities.User", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("Gmails");
                });
#pragma warning restore 612, 618
        }
    }
}
