﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace CardDeckGame.Server.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220919114714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CardDeckId")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardDeckId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Ace of Hearts",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 2,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Two",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 3,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Three",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 4,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Four",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 5,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Five",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 6,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Six",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 7,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Seven",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 8,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Eight",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 9,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Nine",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 10,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Ten",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 11,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Jack",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 12,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "Queen",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 13,
                            CardDeckId = 1,
                            ImgName = "",
                            Name = "King",
                            Suit = "Hearts"
                        });
                });

            modelBuilder.Entity("Entities.Models.CardDeck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CardDeckId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCards")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CardDecks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgName = "",
                            Name = "JackOfAllTrades",
                            TotalCards = 52
                        });
                });

            modelBuilder.Entity("Entities.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HistoryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("Round")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Entities.Models.Card", b =>
                {
                    b.HasOne("Entities.Models.CardDeck", "CardDeck")
                        .WithMany("Cards")
                        .HasForeignKey("CardDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardDeck");
                });

            modelBuilder.Entity("Entities.Models.History", b =>
                {
                    b.HasOne("Entities.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Entities.Models.CardDeck", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}