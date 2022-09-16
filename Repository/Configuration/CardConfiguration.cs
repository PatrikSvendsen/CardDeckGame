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
                Value = 1,
                CardDeckId = 1
            }
        );
    }
}
