﻿// <auto-generated />
using EFForSQLie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFForSQLie.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20180807042829_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("EFForSQLie.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFForSQLie.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogID");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostID");

                    b.HasIndex("BlogID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFForSQLie.Post", b =>
                {
                    b.HasOne("EFForSQLie.Blog", "Blog")
                        .WithMany("Post")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
