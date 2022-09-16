using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        modelbuilder.ApplyConfiguration(new CardDeckConfiguration());
        modelbuilder.ApplyConfiguration(new CardConfiguration());
    }

    public DbSet<CardDeck>? CardDecks { get; set; }
    public DbSet<Card>? Cards { get; set; }
    public DbSet<History>? History { get; set; }
}
