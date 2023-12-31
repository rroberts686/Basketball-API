﻿// <auto-generated />
using System;
using APIofMyChoice.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIofMyChoice.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20230720172729_intital")]
    partial class intital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIofMyChoice.Models.PlayerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Archetype")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("JerseyNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archetype = "Shooting Playmaker",
                            JerseyNumber = 30,
                            Name = "Stephen Curry",
                            Position = "PG",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Archetype = "2-Way Slasher",
                            JerseyNumber = 34,
                            Name = "Giannis Antetokounmpo",
                            Position = "PF",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            Archetype = "2-Way 3pt Specialist",
                            JerseyNumber = 11,
                            Name = "Klay Thompson",
                            Position = "SG",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            Archetype = "Playmaking Big",
                            JerseyNumber = 15,
                            Name = "Nikola Jokic",
                            Position = "C",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 5,
                            Archetype = "2-Way Stretch Big",
                            JerseyNumber = 13,
                            Name = "Jaren Jackson Jr.",
                            Position = "PF",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 6,
                            Archetype = "Slashing Playmaker",
                            JerseyNumber = 0,
                            Name = "Scoot Henderson",
                            Position = "PG",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 7,
                            Archetype = "Unicorn",
                            JerseyNumber = 1,
                            Name = "Victor Wembanyama",
                            Position = "C",
                            TeamId = 6
                        },
                        new
                        {
                            Id = 8,
                            Archetype = "Pure 3pt Specialist",
                            JerseyNumber = 55,
                            Name = "Duncan Robinson",
                            Position = "SG",
                            TeamId = 7
                        },
                        new
                        {
                            Id = 9,
                            Archetype = "Playmaking Shot Creator",
                            JerseyNumber = 1,
                            Name = "Lamelo Ball",
                            Position = "PG",
                            TeamId = 8
                        });
                });

            modelBuilder.Entity("APIofMyChoice.Models.TeamModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TeamModelId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TeamOvr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamModelId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeamName = "Warriors",
                            TeamOvr = 89
                        },
                        new
                        {
                            Id = 2,
                            TeamName = "Bucks",
                            TeamOvr = 94
                        },
                        new
                        {
                            Id = 3,
                            TeamName = "Nuggets",
                            TeamOvr = 97
                        },
                        new
                        {
                            Id = 4,
                            TeamName = "Grizzlies",
                            TeamOvr = 91
                        },
                        new
                        {
                            Id = 5,
                            TeamName = "Trailblazers",
                            TeamOvr = 83
                        },
                        new
                        {
                            Id = 6,
                            TeamName = "Spurs",
                            TeamOvr = 80
                        },
                        new
                        {
                            Id = 7,
                            TeamName = "Heat",
                            TeamOvr = 92
                        },
                        new
                        {
                            Id = 8,
                            TeamName = "Hornets",
                            TeamOvr = 81
                        });
                });

            modelBuilder.Entity("APIofMyChoice.Models.PlayerModel", b =>
                {
                    b.HasOne("APIofMyChoice.Models.TeamModel", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("APIofMyChoice.Models.TeamModel", b =>
                {
                    b.HasOne("APIofMyChoice.Models.TeamModel", null)
                        .WithMany("Players")
                        .HasForeignKey("TeamModelId");
                });

            modelBuilder.Entity("APIofMyChoice.Models.TeamModel", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
