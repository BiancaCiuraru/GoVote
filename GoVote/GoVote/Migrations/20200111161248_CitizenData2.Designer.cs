﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations
{
    [DbContext(typeof(CitizenDatabaseContext))]
    [Migration("20200111161248_CitizenData2")]
    partial class CitizenData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.Citizen", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VotedFor")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Citizens");

                    b.HasData(
                        new
                        {
                            ID = new Guid("c6cc8afe-3fb7-49e3-8726-a479ed2f9628"),
                            Address = "Prelungirea Salciei nr 11",
                            CNP = "6000611068050",
                            City = "Bacau",
                            County = "Bacau",
                            FirstName = "Andreea",
                            LastName = "Rindasu",
                            Sex = "Female",
                            VotedFor = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            ID = new Guid("75a2b1a9-2a84-492a-9d88-609754d51829"),
                            Address = "Trandafirilor nr 19",
                            CNP = "2940306114529",
                            City = "Iasi",
                            County = "Iasi",
                            FirstName = "Andreea",
                            LastName = "Arsene",
                            Sex = "Female",
                            VotedFor = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}