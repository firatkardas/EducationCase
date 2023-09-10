﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230908100042_initial5")]
    partial class initial5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Entitities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("article")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("classroomTraining")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("miniProject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("online")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("presentation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Entitities.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("cost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("instructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("limit")
                        .HasColumnType("int");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("instructorId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("EntityLayer.Entitities.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("externalTrainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("innerTrainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EntityLayer.Entitities.Education", b =>
                {
                    b.HasOne("EntityLayer.Entitities.Category", "Category")
                        .WithMany("Educations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entitities.Instructor", "instructor")
                        .WithMany()
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("EntityLayer.Entitities.Category", b =>
                {
                    b.Navigation("Educations");
                });
#pragma warning restore 612, 618
        }
    }
}
