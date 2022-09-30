using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repository;
using Service;
using Service.Contracts;

namespace CardDeckGame.Server.Extensions;

public static class ServiceExtensions
{
    // Används för att konfiguera Entity Framework med RepositoryContextet.
    public static void ConfigureSqlContext(this IServiceCollection services,
        IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

    // Används för Swagger-dokumentation för API-kontrollers
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Card Deck Game API",
                Version = "v1"
            });
            s.SwaggerDoc("v2", new OpenApiInfo
            {
                Title = "Card Deck Game API",
                Version = "v2"
            });
        });
    }

    // Används för att konfiguera ISS-programet
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
         services.Configure<IISOptions>(options => { });

    // Injektar Loggern som Singleton, för att erhålla samma logger genom allt.
    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    // Injektar Repository managern.
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    // Injektar Service managern
    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();
}

