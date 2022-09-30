using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

// Databaskontext. Här används Entity Framework för att skapa databasen. 
public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }


    // Nedan laddar in all information till databasen. Sker när man kör update-database
    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        modelbuilder.ApplyConfiguration(new CardDeckConfiguration());
        modelbuilder.ApplyConfiguration(new CardConfiguration());
        modelbuilder.ApplyConfiguration(new HistoryConfiguration());
    }


    // Nedan skapar tabellerna i databasen.
    public DbSet<CardDeck>? CardDecks { get; set; }
    public DbSet<Card>? Cards { get; set; }
    public DbSet<History>? History { get; set; }
}
