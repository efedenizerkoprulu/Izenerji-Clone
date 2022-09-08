﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(İzenerjiContext))]
    [Migration("20220908050117_izenerji")]
    partial class izenerji
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("Varchar(40)")
                        .HasColumnName("Name");

                    b.Property<int>("SuccsessPercentage")
                        .HasColumnType("int")
                        .HasColumnName("SuccsessPercentage");

                    b.HasKey("Id");

                    b.ToTable("Abilities", (string)null);
                });

            modelBuilder.Entity("Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasColumnName("Date")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles", (string)null);
                });

            modelBuilder.Entity("Entities.ArticleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleID")
                        .HasColumnType("int")
                        .HasColumnName("ArticleID");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasColumnName("Explanation");

                    b.HasKey("Id");

                    b.HasIndex("ArticleID")
                        .IsUnique();

                    b.ToTable("ArticleDetails", (string)null);
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Entities.ChartData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Data")
                        .HasColumnType("int")
                        .HasColumnName("Data");

                    b.Property<int>("DayId")
                        .HasColumnType("int")
                        .HasColumnName("DayId");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("ChartDatas", (string)null);
                });

            modelBuilder.Entity("Entities.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("Varchar(40)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Days", (string)null);
                });

            modelBuilder.Entity("Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(MAX)")
                        .HasColumnName("Explanation");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Firstname");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Lastname");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Entities.İmageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Explanation");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("ImageItems", (string)null);
                });

            modelBuilder.Entity("Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Sliders", (string)null);
                });

            modelBuilder.Entity("Entities.SliderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasColumnName("Explanation");

                    b.Property<int>("SliderID")
                        .HasColumnType("int")
                        .HasColumnName("SliderID");

                    b.HasKey("Id");

                    b.HasIndex("SliderID")
                        .IsUnique();

                    b.ToTable("SliderDetails", (string)null);
                });

            modelBuilder.Entity("Entities.Twitter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tweet")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(MAX)")
                        .HasColumnName("Tweet");

                    b.HasKey("Id");

                    b.ToTable("Twitters", (string)null);
                });

            modelBuilder.Entity("Entities.Article", b =>
                {
                    b.HasOne("Entities.Category", "Category")
                        .WithMany("articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.ArticleDetail", b =>
                {
                    b.HasOne("Entities.Article", "Article")
                        .WithOne("articleDetail")
                        .HasForeignKey("Entities.ArticleDetail", "ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Entities.ChartData", b =>
                {
                    b.HasOne("Entities.Day", "Day")
                        .WithMany("Charts")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("Entities.SliderDetail", b =>
                {
                    b.HasOne("Entities.Slider", "Slider")
                        .WithOne("SliderDetail")
                        .HasForeignKey("Entities.SliderDetail", "SliderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slider");
                });

            modelBuilder.Entity("Entities.Article", b =>
                {
                    b.Navigation("articleDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Navigation("articles");
                });

            modelBuilder.Entity("Entities.Day", b =>
                {
                    b.Navigation("Charts");
                });

            modelBuilder.Entity("Entities.Slider", b =>
                {
                    b.Navigation("SliderDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}