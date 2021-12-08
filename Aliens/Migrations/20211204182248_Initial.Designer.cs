﻿// <auto-generated />
using System;
using Aliens.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aliens.Migrations
{
    [DbContext(typeof(AliensContext))]
    [Migration("20211204182248_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Aliens.Database.Abduction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_alienid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceshipid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_alienid");

                    b.HasIndex("id_personid");

                    b.HasIndex("id_spaceshipid");

                    b.ToTable("abductions");
                });

            modelBuilder.Entity("Aliens.Database.Aliens", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("planet")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("aliens");
                });

            modelBuilder.Entity("Aliens.Database.Escape", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceshipid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_personid");

                    b.HasIndex("id_spaceshipid");

                    b.ToTable("escapes");
                });

            modelBuilder.Entity("Aliens.Database.Excursion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_alienid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_group_peopleid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceshipid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_alienid");

                    b.HasIndex("id_group_peopleid");

                    b.HasIndex("id_spaceshipid");

                    b.ToTable("excursions");
                });

            modelBuilder.Entity("Aliens.Database.Experiment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_group_aliensid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceshipid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_group_aliensid");

                    b.HasIndex("id_personid");

                    b.HasIndex("id_spaceshipid");

                    b.ToTable("experiments");
                });

            modelBuilder.Entity("Aliens.Database.GroupAndAlien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("id_alienid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_groupid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_alienid");

                    b.HasIndex("id_groupid");

                    b.ToTable("group_alien");
                });

            modelBuilder.Entity("Aliens.Database.GroupAndPerson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("id_groupid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_groupid");

                    b.HasIndex("id_personid");

                    b.ToTable("group_person");
                });

            modelBuilder.Entity("Aliens.Database.GroupsOfAliens", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("id");

                    b.ToTable("groups_aliens");
                });

            modelBuilder.Entity("Aliens.Database.GroupsOfPeople", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("id");

                    b.ToTable("groups_people");
                });

            modelBuilder.Entity("Aliens.Database.Murder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_alienid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_alienid");

                    b.HasIndex("id_personid");

                    b.ToTable("murders");
                });

            modelBuilder.Entity("Aliens.Database.People", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("people");
                });

            modelBuilder.Entity("Aliens.Database.Spaceship", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("model")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("spaceships");
                });

            modelBuilder.Entity("Aliens.Database.Transportation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("id_alienid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_personid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceship_fromid")
                        .HasColumnType("integer");

                    b.Property<int?>("id_spaceship_toid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_alienid");

                    b.HasIndex("id_personid");

                    b.HasIndex("id_spaceship_fromid");

                    b.HasIndex("id_spaceship_toid");

                    b.ToTable("transportations");
                });

            modelBuilder.Entity("Aliens.Database.Abduction", b =>
                {
                    b.HasOne("Aliens.Database.Aliens", "id_alien")
                        .WithMany()
                        .HasForeignKey("id_alienid");

                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship")
                        .WithMany()
                        .HasForeignKey("id_spaceshipid");
                });

            modelBuilder.Entity("Aliens.Database.Escape", b =>
                {
                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship")
                        .WithMany()
                        .HasForeignKey("id_spaceshipid");
                });

            modelBuilder.Entity("Aliens.Database.Excursion", b =>
                {
                    b.HasOne("Aliens.Database.Aliens", "id_alien")
                        .WithMany()
                        .HasForeignKey("id_alienid");

                    b.HasOne("Aliens.Database.GroupsOfPeople", "id_group_people")
                        .WithMany()
                        .HasForeignKey("id_group_peopleid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship")
                        .WithMany()
                        .HasForeignKey("id_spaceshipid");
                });

            modelBuilder.Entity("Aliens.Database.Experiment", b =>
                {
                    b.HasOne("Aliens.Database.GroupsOfAliens", "id_group_aliens")
                        .WithMany()
                        .HasForeignKey("id_group_aliensid");

                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship")
                        .WithMany()
                        .HasForeignKey("id_spaceshipid");
                });

            modelBuilder.Entity("Aliens.Database.GroupAndAlien", b =>
                {
                    b.HasOne("Aliens.Database.Aliens", "id_alien")
                        .WithMany()
                        .HasForeignKey("id_alienid");

                    b.HasOne("Aliens.Database.GroupsOfAliens", "id_group")
                        .WithMany()
                        .HasForeignKey("id_groupid");
                });

            modelBuilder.Entity("Aliens.Database.GroupAndPerson", b =>
                {
                    b.HasOne("Aliens.Database.GroupsOfPeople", "id_group")
                        .WithMany()
                        .HasForeignKey("id_groupid");

                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");
                });

            modelBuilder.Entity("Aliens.Database.Murder", b =>
                {
                    b.HasOne("Aliens.Database.Aliens", "id_alien")
                        .WithMany()
                        .HasForeignKey("id_alienid");

                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");
                });

            modelBuilder.Entity("Aliens.Database.Transportation", b =>
                {
                    b.HasOne("Aliens.Database.Aliens", "id_alien")
                        .WithMany()
                        .HasForeignKey("id_alienid");

                    b.HasOne("Aliens.Database.People", "id_person")
                        .WithMany()
                        .HasForeignKey("id_personid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship_from")
                        .WithMany()
                        .HasForeignKey("id_spaceship_fromid");

                    b.HasOne("Aliens.Database.Spaceship", "id_spaceship_to")
                        .WithMany()
                        .HasForeignKey("id_spaceship_toid");
                });
#pragma warning restore 612, 618
        }
    }
}
