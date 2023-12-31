﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatBeyrerJL02.Data;

#nullable disable

namespace RecruitCatBeyrerJL02.Migrations
{
    [DbContext(typeof(RecruitCatBeyrerJL02Context))]
    partial class RecruitCatBeyrerJL02ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsVeteran")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("TitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("FulltimeEmp")
                        .HasColumnType("int");

                    b.Property<bool>("Hiring")
                        .HasColumnType("bit");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal?>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal?>("Reveune")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IndustryName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("RequiresDegree")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatBeyrerJL02.Models.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId");

                    b.HasOne("RecruitCatBeyrerJL02.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatBeyrerJL02.Models.JobTitle", "Title")
                        .WithMany("Candidates")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Industry");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Company", b =>
                {
                    b.HasOne("RecruitCatBeyrerJL02.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Company", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.Industry", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("RecruitCatBeyrerJL02.Models.JobTitle", b =>
                {
                    b.Navigation("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
