﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Infrastructure;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    [DbContext(typeof(ComicsContext))]
    [Migration("20220922174958_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharacterPower", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("PowersId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "PowersId");

                    b.HasIndex("PowersId");

                    b.ToTable("CharacterPower");
                });

            modelBuilder.Entity("MyApp.Infrastructure.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlterEgo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<short?>("FirstAppearance")
                        .HasColumnType("smallint");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GivenName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Occupation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("MyApp.Infrastructure.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MyApp.Infrastructure.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("CharacterPower", b =>
                {
                    b.HasOne("MyApp.Infrastructure.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyApp.Infrastructure.Power", null)
                        .WithMany()
                        .HasForeignKey("PowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Infrastructure.Character", b =>
                {
                    b.HasOne("MyApp.Infrastructure.City", "City")
                        .WithMany("Characters")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("MyApp.Infrastructure.City", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}