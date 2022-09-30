using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace CardDeckGame.Server.ContextFactory;

// Denna class används för att bygga EntityFramework samt för att lägga Migrations-mappen i Server-projektet (utan denna kod hade Migrations hamnat i CardDeckGame.Presentation projektet och det vill man inte.
public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var builder = new DbContextOptionsBuilder<RepositoryContext>()
        .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
        b => b.MigrationsAssembly("CardDeckGame.Server"));

        return new RepositoryContext(builder.Options);
    }
}
