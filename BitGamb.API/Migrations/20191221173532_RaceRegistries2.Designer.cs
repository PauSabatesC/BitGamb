﻿// <auto-generated />
using System;
using BitGamb.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BitGamb.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191221173532_RaceRegistries2")]
    partial class RaceRegistries2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BitGamb.API.Models.RaceRegistries", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("RobotRaceid")
                        .HasColumnType("integer");

                    b.Property<int?>("Robotid")
                        .HasColumnType("integer");

                    b.Property<int?>("Userid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("RobotRaceid");

                    b.HasIndex("Robotid");

                    b.HasIndex("Userid");

                    b.ToTable("RaceRegistries");
                });

            modelBuilder.Entity("BitGamb.API.Models.Robot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LastRacePosition")
                        .HasColumnType("integer");

                    b.Property<string>("robotName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Robots");
                });

            modelBuilder.Entity("BitGamb.API.Models.RobotRace", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("reward")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("RobotRaces");
                });

            modelBuilder.Entity("BitGamb.API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<byte[]>("passwordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("passwordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BitGamb.API.Models.RaceRegistries", b =>
                {
                    b.HasOne("BitGamb.API.Models.RobotRace", "RobotRace")
                        .WithMany()
                        .HasForeignKey("RobotRaceid");

                    b.HasOne("BitGamb.API.Models.Robot", "Robot")
                        .WithMany()
                        .HasForeignKey("Robotid");

                    b.HasOne("BitGamb.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid");
                });
#pragma warning restore 612, 618
        }
    }
}