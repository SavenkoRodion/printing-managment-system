﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS_Api.Model.DbModel;

#nullable disable

namespace PMS_Api.Migrations
{
    [DbContext(typeof(PmsContext))]
    partial class PmsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PMS_Api.Model.DbModel.Admin", b =>
                {
                    b.Property<Guid>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly?>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uuid");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Uuid = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                            CreatedAt = new DateOnly(2024, 11, 4),
                            Email = "testemail@test.com",
                            Name = "Admin",
                            Password = "1234"
                        },
                        new
                        {
                            Uuid = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                            CreatedAt = new DateOnly(2024, 7, 4),
                            Email = "admin@test.com",
                            Name = "Administrator",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Client", b =>
                {
                    b.Property<Guid>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uuid");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Uuid = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                            Address = "Address A",
                            DateOfCreation = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1071),
                            Email = "client1@test.pl",
                            Name = "Client A"
                        },
                        new
                        {
                            Uuid = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                            Address = "Address B",
                            DateOfCreation = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1110),
                            Email = "client2@test.com",
                            Name = "Client B"
                        });
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Parameter", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Product", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1127),
                            Name = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1129),
                            Name = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            DateOfCreation = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1131),
                            Name = "Product 3"
                        });
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LiczbaStron")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                            ClientId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1148),
                            Format = "A4",
                            LiczbaStron = 100,
                            Name = "Project 1",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            AdminId = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                            ClientId = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1151),
                            Format = "A3",
                            LiczbaStron = 200,
                            Name = "Project 2",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            AdminId = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                            ClientId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1153),
                            Format = "A5",
                            LiczbaStron = 300,
                            Name = "Project 3",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            AdminId = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                            ClientId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1155),
                            Format = "A6",
                            LiczbaStron = 400,
                            Name = "Project 4",
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LiczbaStron")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductId");

                    b.ToTable("Templates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                            ClientId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1170),
                            Format = "A4",
                            LiczbaStron = 100,
                            Name = "Template 1",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            AdminId = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                            ClientId = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1173),
                            Format = "A3",
                            LiczbaStron = 200,
                            Name = "Template 2",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            AdminId = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                            ClientId = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                            DateModified = new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1175),
                            Format = "A5",
                            LiczbaStron = 300,
                            Name = "Template 3",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Project", b =>
                {
                    b.HasOne("PMS_Api.Model.DbModel.Admin", "Author")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_Api.Model.DbModel.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_Api.Model.DbModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Client");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PMS_Api.Model.DbModel.Template", b =>
                {
                    b.HasOne("PMS_Api.Model.DbModel.Admin", "Author")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_Api.Model.DbModel.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_Api.Model.DbModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Client");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
