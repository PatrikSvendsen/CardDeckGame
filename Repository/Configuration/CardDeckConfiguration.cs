using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

//Denna class används för att lägga till information i databasen.
//Allt läggs in en gång och endast när man kör update-database i package manager console.
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
