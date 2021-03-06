﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using parser.Data;

namespace parser.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201109021650_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("parser.Models.Artifact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CRN")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("Level")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RubricId")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("StudentId")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Term")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CRN");

                    b.HasIndex("FacultyId");

                    b.HasIndex("RubricId");

                    b.ToTable("Artifacts");
                });

            modelBuilder.Entity("parser.Models.CourseSection", b =>
                {
                    b.Property<int>("CRN")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CRN");

                    b.HasIndex("FacultyId");

                    b.ToTable("CourseSections");
                });

            modelBuilder.Entity("parser.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RubricId")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("RubricId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("parser.Models.Rubric", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Rubrics");
                });

            modelBuilder.Entity("parser.Models.RubricCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desciption0")
                        .HasColumnType("text");

                    b.Property<string>("Desciption1")
                        .HasColumnType("text");

                    b.Property<string>("Desciption2")
                        .HasColumnType("text");

                    b.Property<string>("Desciption3")
                        .HasColumnType("text");

                    b.Property<string>("Desciption4")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RubricId")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("RubricId");

                    b.ToTable("RubricCriteria");
                });

            modelBuilder.Entity("parser.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtifactId")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("RubricCriteriaId")
                        .HasColumnType("text");

                    b.Property<int?>("RubricCriteriaId1")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtifactId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("RubricCriteriaId1");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("parser.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("parser.Models.Artifact", b =>
                {
                    b.HasOne("parser.Models.CourseSection", "CourseSection")
                        .WithMany()
                        .HasForeignKey("CRN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("parser.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("parser.Models.Rubric", "Rubric")
                        .WithMany("Artifacts")
                        .HasForeignKey("RubricId");
                });

            modelBuilder.Entity("parser.Models.CourseSection", b =>
                {
                    b.HasOne("parser.Models.Faculty", "Faculty")
                        .WithMany("CourseSections")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("parser.Models.Faculty", b =>
                {
                    b.HasOne("parser.Models.Rubric", "Rubric")
                        .WithMany("Faculty")
                        .HasForeignKey("RubricId");
                });

            modelBuilder.Entity("parser.Models.RubricCriteria", b =>
                {
                    b.HasOne("parser.Models.Rubric", "Rubric")
                        .WithMany("RubricCriteria")
                        .HasForeignKey("RubricId");
                });

            modelBuilder.Entity("parser.Models.Score", b =>
                {
                    b.HasOne("parser.Models.Artifact", "Artifact")
                        .WithMany("Scores")
                        .HasForeignKey("ArtifactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("parser.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("parser.Models.RubricCriteria", "RubricCriteria")
                        .WithMany("Scores")
                        .HasForeignKey("RubricCriteriaId1");
                });
#pragma warning restore 612, 618
        }
    }
}
