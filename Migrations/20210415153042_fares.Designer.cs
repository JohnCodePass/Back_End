﻿// <auto-generated />
using Back_End.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Back_End.Migrations
{
    [DbContext(typeof(Data))]
    [Migration("20210415153042_fares")]
    partial class fares
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back_End.Models.Fare", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("riderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("routeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Fares");

                    b.HasData(
                        new
                        {
                            id = 1,
                            price = "$1.50",
                            riderType = "Full-test",
                            routeType = "Local-test",
                            type = "1-Ride"
                        });
                });

            modelBuilder.Entity("Back_End.Models.Path", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("route")
                        .HasColumnType("int");

                    b.Property<string>("stops")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trips")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeOfDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeOfRoute")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Paths");

                    b.HasData(
                        new
                        {
                            id = 1,
                            direction = "North",
                            route = 42,
                            stops = "['stop 1']",
                            trips = "[['9:55am']]",
                            typeOfDay = "Weekday",
                            typeOfRoute = "BRT-Express"
                        });
                });

            modelBuilder.Entity("Back_End.Models.RiderAlert", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RiderAlert");
                });

            modelBuilder.Entity("Back_End.Models.Route", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Routes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            number = 40,
                            type = "BART EXPRESS"
                        });
                });

            modelBuilder.Entity("Back_End.Models.Stop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stopName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Stop");
                });

            modelBuilder.Entity("Back_End.Models.UserFavorate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("destinationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("savedStop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Favorate");
                });

            modelBuilder.Entity("Back_End.Models.UserInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "email",
                            password = "password",
                            username = "huegogh"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
