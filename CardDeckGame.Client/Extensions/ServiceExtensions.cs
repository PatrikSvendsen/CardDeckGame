using CardDeckGame.Client.HttpRepository.CardDeckHttp;
using CardDeckGame.Client.HttpRepository.CardHttp;
using CardDeckGame.Client.HttpRepository.HistoryHttp;

namespace CardDeckGame.Client.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICardDeckHttpRepository, CardDeckHttpRepository>();
        services.AddScoped<ICardHttpRepository, CardHttpRepository>();
        services.AddScoped<IHistoryHttpRepository, HistoryHttpRepository>();
    }
}
