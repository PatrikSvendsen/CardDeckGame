using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.HasData
        (
            new Card
            {
                Id = 1,
                Name = "Ace of Hearts",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/ace.png"
            },
            new Card
            {
                Id = 2,
                Name = "Two",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/2.png"
            },
            new Card
            {
                Id = 3,
                Name = "Three",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/3.png"
            },
            new Card
            {
                Id = 4,
                Name = "Four",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/4.png"
            },
            new Card
            {
                Id = 5,
                Name = "Five",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/5.png"
            },
            new Card
            {
                Id = 6,
                Name = "Six",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/6.png"
            },
            new Card
            {
                Id = 7,
                Name = "Seven",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/7.png"
            },
            new Card
            {
                Id = 8,
                Name = "Eight",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/8.png"
            },
            new Card
            {
                Id = 9,
                Name = "Nine",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/9.png"
            },
            new Card
            {
                Id = 10,
                Name = "Ten",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/10.png"
            },
            new Card
            {
                Id = 11,
                Name = "Jack",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/jack.png"
            },
            new Card
            {
                Id = 12,
                Name = "Queen",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/queen.png"
            },
            new Card
            {
                Id = 13,
                Name = "King",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/king.png"
            },
            new Card
            {
                Id = 14,
                Name = "Ace of Clubs",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/ace.png"
            },
            new Card
            {
                Id = 15,
                Name = "Two",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/2.png"
            },
            new Card
            {
                Id = 16,
                Name = "Three",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/3.png"
            },
            new Card
            {
                Id = 17,
                Name = "Four",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/4.png"
            },
            new Card
            {
                Id = 18,
                Name = "Five",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/5.png"
            },
            new Card
            {
                Id = 19,
                Name = "Six",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/6.png"
            },
            new Card
            {
                Id = 20,
                Name = "Seven",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/7.png"
            },
            new Card
            {
                Id = 21,
                Name = "Eight",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/8.png"
            },
            new Card
            {
                Id = 22,
                Name = "Nine",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/9.png"
            },
            new Card
            {
                Id = 23,
                Name = "Ten",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/10.png"
            },
            new Card
            {
                Id = 24,
                Name = "Jack",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/jack.png"
            },
            new Card
            {
                Id = 25,
                Name = "Queen",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/queen.png"
            },
            new Card
            {
                Id = 26,
                Name = "King",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/king.png"
            },
            new Card
            {
                Id = 27,
                Name = "Ace of Spades",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/ace.png"
            },
            new Card
            {
                Id = 28,
                Name = "Two",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/2.png"
            },
            new Card
            {
                Id = 29,
                Name = "Three",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/3.png"
            },
            new Card
            {
                Id = 30,
                Name = "Four",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/4.png"
            },
            new Card
            {
                Id = 31,
                Name = "Five",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/5.png"
            },
            new Card
            {
                Id = 32,
                Name = "Six",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/6.png"
            },
            new Card
            {
                Id = 33,
                Name = "Seven",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/7.png"
            },
            new Card
            {
                Id = 34,
                Name = "Eight",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/8.png"
            },
            new Card
            {
                Id = 35,
                Name = "Nine",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/9.png"
            },
            new Card
            {
                Id = 36,
                Name = "Ten",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/10.png"
            },
            new Card
            {
                Id = 37,
                Name = "Jack",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/jack.png"
            },
            new Card
            {
                Id = 38,
                Name = "Queen",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/queen.png"
            },
            new Card
            {
                Id = 39,
                Name = "King",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/king.png"
            },
            new Card
            {
                Id = 40,
                Name = "Ace of Diamonds",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/ace.png"
            },
            new Card
            {
                Id = 41,
                Name = "Two",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/2.png"
            },
            new Card
            {
                Id = 42,
                Name = "Three",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/3.png"
            },
            new Card
            {
                Id = 43,
                Name = "Four",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/4.png"
            },
            new Card
            {
                Id = 44,
                Name = "Five",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/5.png"
            },
            new Card
            {
                Id = 45,
                Name = "Six",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/6.png"
            },
            new Card
            {
                Id = 46,
                Name = "Seven",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/7.png"
            },
            new Card
            {
                Id = 47,
                Name = "Eight",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/8.png"
            },
            new Card
            {
                Id = 48,
                Name = "Nine",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/9.png"
            },
            new Card
            {
                Id = 49,
                Name = "Ten",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/10.png"
            },
            new Card
            {
                Id = 50,
                Name = "Jack",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/jack.png"
            },
            new Card
            {
                Id = 51,
                Name = "Queen",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/queen.png"
            },
            new Card
            {
                Id = 52,
                Name = "King",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/king.png"
            }
        );
    }
}
