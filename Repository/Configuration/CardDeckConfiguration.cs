using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CardDeckConfiguration : IEntityTypeConfiguration<CardDeck>
{
    public void Configure(EntityTypeBuilder<CardDeck> builder)
    {
        builder.HasData
        (
            new CardDeck
            {
                Id = 1,
                Name = "JackOfAllTrades",
                TotalCards = 52
            }
        );
    }
}
