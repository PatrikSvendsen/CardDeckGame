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
                CardDeckId = 1
            },
            new Card
            {
                Id = 2,
                Name = "Two",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 3,
                Name = "Three",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 4,
                Name = "Four",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 5,
                Name = "Five",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 6,
                Name = "Six",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 7,
                Name = "Seven",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 8,
                Name = "Eight",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 9,
                Name = "Nine",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 10,
                Name = "Ten",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 11,
                Name = "Jack",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 12,
                Name = "Queen",
                Suit = "Hearts",
                CardDeckId = 1
            },
            new Card
            {
                Id = 13,
                Name = "King",
                Suit = "Hearts",
                CardDeckId = 1
            }
        );
    }
}
