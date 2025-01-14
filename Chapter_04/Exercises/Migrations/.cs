﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBGList.Model;

#nullable disable

namespace MyBGList.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyBGList.Model.BoardGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlternateNames")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("BGGRank")
                        .HasColumnType("int");

                    b.Property<decimal>("ComplexityAverage")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designer")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Flags")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OwnedUsers")
                        .HasColumnType("int");

                    b.Property<int>("PlayTime")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<decimal>("RatingAverage")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("UsersRated")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("BoardGames");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Categories", b =>
                {
                    b.Property<int>("BoardGameId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoardGameId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BoardGames_Categories");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Domains", b =>
                {
                    b.Property<int>("BoardGameId")
                        .HasColumnType("int");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoardGameId", "DomainId");

                    b.HasIndex("DomainId");

                    b.ToTable("BoardGames_Domains");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Mechanics", b =>
                {
                    b.Property<int>("BoardGameId")
                        .HasColumnType("int");

                    b.Property<int>("MechanicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoardGameId", "MechanicId");

                    b.HasIndex("MechanicId");

                    b.ToTable("BoardGames_Mechanics");
                });

            modelBuilder.Entity("MyBGList.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyBGList.Model.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Flags")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("MyBGList.Model.Mechanic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Flags")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Mechanics");
                });

            modelBuilder.Entity("MyBGList.Model.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGame", b =>
                {
                    b.HasOne("MyBGList.Model.Publisher", "Publisher")
                        .WithMany("BoardGames")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Categories", b =>
                {
                    b.HasOne("MyBGList.Model.BoardGame", "BoardGame")
                        .WithMany("BoardGames_Categories")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBGList.Model.Category", "Category")
                        .WithMany("BoardGames_Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardGame");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Domains", b =>
                {
                    b.HasOne("MyBGList.Model.BoardGame", "BoardGame")
                        .WithMany("BoardGames_Domains")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBGList.Model.Domain", "Domain")
                        .WithMany("BoardGames_Domains")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardGame");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGames_Mechanics", b =>
                {
                    b.HasOne("MyBGList.Model.BoardGame", "BoardGame")
                        .WithMany("BoardGames_Mechanics")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBGList.Model.Mechanics", "Mechanics")
                        .WithMany("BoardGames_Mechanics")
                        .HasForeignKey("MechanicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardGame");

                    b.Navigation("Mechanics");
                });

            modelBuilder.Entity("MyBGList.Model.BoardGame", b =>
                {
                    b.Navigation("BoardGames_Categories");

                    b.Navigation("BoardGames_Domains");

                    b.Navigation("BoardGames_Mechanics");
                });

            modelBuilder.Entity("MyBGList.Model.Category", b =>
                {
                    b.Navigation("BoardGames_Categories");
                });

            modelBuilder.Entity("MyBGList.Model.Domain", b =>
                {
                    b.Navigation("BoardGames_Domains");
                });

            modelBuilder.Entity("MyBGList.Model.Mechanic", b =>
                {
                    b.Navigation("BoardGames_Mechanics");
                });

            modelBuilder.Entity("MyBGList.Model.Publisher", b =>
                {
                    b.Navigation("BoardGames");
                });
#pragma warning restore 612, 618
        }
    }
}
