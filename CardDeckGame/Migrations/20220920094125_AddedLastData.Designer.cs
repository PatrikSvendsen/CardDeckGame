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
    [Migration("20220920094125_AddedLastData")]
    partial class AddedLastData
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
                            ImgName = "/images/hearts/ace.png",
                            Name = "Ace of Hearts",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 2,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/2.png",
                            Name = "Two",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 3,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/3.png",
                            Name = "Three",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 4,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/4.png",
                            Name = "Four",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 5,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/5.png",
                            Name = "Five",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 6,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/6.png",
                            Name = "Six",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 7,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/7.png",
                            Name = "Seven",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 8,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/8.png",
                            Name = "Eight",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 9,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/9.png",
                            Name = "Nine",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 10,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/10.png",
                            Name = "Ten",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 11,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/jack.png",
                            Name = "Jack",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 12,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/queen.png",
                            Name = "Queen",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 13,
                            CardDeckId = 1,
                            ImgName = "/images/hearts/king.png",
                            Name = "King",
                            Suit = "Hearts"
                        },
                        new
                        {
                            Id = 14,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/ace.png",
                            Name = "Ace of Clubs",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 15,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/2.png",
                            Name = "Two",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 16,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/3.png",
                            Name = "Three",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 17,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/4.png",
                            Name = "Four",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 18,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/5.png",
                            Name = "Five",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 19,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/6.png",
                            Name = "Six",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 20,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/7.png",
                            Name = "Seven",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 21,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/8.png",
                            Name = "Eight",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 22,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/9.png",
                            Name = "Nine",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 23,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/10.png",
                            Name = "Ten",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 24,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/jack.png",
                            Name = "Jack",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 25,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/queen.png",
                            Name = "Queen",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 26,
                            CardDeckId = 1,
                            ImgName = "/images/clubs/king.png",
                            Name = "King",
                            Suit = "Clubs"
                        },
                        new
                        {
                            Id = 27,
                            CardDeckId = 1,
                            ImgName = "/images/spades/ace.png",
                            Name = "Ace of Spades",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 28,
                            CardDeckId = 1,
                            ImgName = "/images/spades/2.png",
                            Name = "Two",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 29,
                            CardDeckId = 1,
                            ImgName = "/images/spades/3.png",
                            Name = "Three",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 30,
                            CardDeckId = 1,
                            ImgName = "/images/spades/4.png",
                            Name = "Four",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 31,
                            CardDeckId = 1,
                            ImgName = "/images/spades/5.png",
                            Name = "Five",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 32,
                            CardDeckId = 1,
                            ImgName = "/images/spades/6.png",
                            Name = "Six",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 33,
                            CardDeckId = 1,
                            ImgName = "/images/spades/7.png",
                            Name = "Seven",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 34,
                            CardDeckId = 1,
                            ImgName = "/images/spades/8.png",
                            Name = "Eight",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 35,
                            CardDeckId = 1,
                            ImgName = "/images/spades/9.png",
                            Name = "Nine",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 36,
                            CardDeckId = 1,
                            ImgName = "/images/spades/10.png",
                            Name = "Ten",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 37,
                            CardDeckId = 1,
                            ImgName = "/images/spades/jack.png",
                            Name = "Jack",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 38,
                            CardDeckId = 1,
                            ImgName = "/images/spades/queen.png",
                            Name = "Queen",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 39,
                            CardDeckId = 1,
                            ImgName = "/images/spades/king.png",
                            Name = "King",
                            Suit = "Spades"
                        },
                        new
                        {
                            Id = 40,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/ace.png",
                            Name = "Ace of Diamonds",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 41,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/2.png",
                            Name = "Two",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 42,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/3.png",
                            Name = "Three",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 43,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/4.png",
                            Name = "Four",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 44,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/5.png",
                            Name = "Five",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 45,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/6.png",
                            Name = "Six",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 46,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/7.png",
                            Name = "Seven",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 47,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/8.png",
                            Name = "Eight",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 48,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/9.png",
                            Name = "Nine",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 49,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/10.png",
                            Name = "Ten",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 50,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/jack.png",
                            Name = "Jack",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 51,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/queen.png",
                            Name = "Queen",
                            Suit = "Diamonds"
                        },
                        new
                        {
                            Id = 52,
                            CardDeckId = 1,
                            ImgName = "/images/diamonds/king.png",
                            Name = "King",
                            Suit = "Diamonds"
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