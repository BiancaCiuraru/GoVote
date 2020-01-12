﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations.PartyDatabase
{
    [DbContext(typeof(PartyDatabaseContext))]
    [Migration("20200112160851_PartyDb")]
    partial class PartyDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.Party", b =>
                {
                    b.Property<Guid>("PartyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PartyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyID");

                    b.ToTable("Parties");

                    b.HasData(
                        new
                        {
                            PartyID = new Guid("eb14b17c-23ee-42d6-8b8f-8c1569c71900"),
                            PartyName = "Partidul Național Liberal"
                        },
                        new
                        {
                            PartyID = new Guid("87956373-a20e-4c9a-b6db-e62ed99308eb"),
                            PartyName = "Partidul Social Democrat"
                        },
                        new
                        {
                            PartyID = new Guid("a7dd53e5-0ed5-443d-a8f6-c3cedab4feb0"),
                            PartyName = "Uniunea Salvați România"
                        },
                        new
                        {
                            PartyID = new Guid("b0d619d7-f409-4fdc-9e7c-e8fc780e2e31"),
                            PartyName = "Alianța Liberalilor și Democraților"
                        },
                        new
                        {
                            PartyID = new Guid("e5a072d9-06f5-4fab-88c9-7a1f6c8cb062"),
                            PartyName = "Partidul România Unită"
                        },
                        new
                        {
                            PartyID = new Guid("cdf668b2-911d-49f6-998d-e212f1b054f8"),
                            PartyName = "Partidul Noua Revoluție"
                        },
                        new
                        {
                            PartyID = new Guid("10b098a5-cbbf-4d7a-9e9c-4b50639e5ca4"),
                            PartyName = "Alianța Noastră România"
                        },
                        new
                        {
                            PartyID = new Guid("8157a0b7-2b67-41b8-a764-4b80a628b696"),
                            PartyName = "Partidul România Mare"
                        },
                        new
                        {
                            PartyID = new Guid("a6d6c337-d870-4fd7-829d-c5bb240c68b5"),
                            PartyName = "Pro România"
                        },
                        new
                        {
                            PartyID = new Guid("37545b86-03be-41c0-b99c-64642b028073"),
                            PartyName = "Uniunea Democrată Maghiară din România"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
