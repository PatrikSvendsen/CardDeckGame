using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CardDeck>? CardDecks { get; set; }
    public DbSet<Card>? Cards { get; set; }
}
