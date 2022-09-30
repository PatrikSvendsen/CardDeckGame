using Shared.DataTransferObjects.CardDeck;
using System.Text.Json;

namespace CardDeckGame.Client.HttpRepository.CardDeckHttp;

public class CardDeckHttpRepository : ICardDeckHttpRepository
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _options;

    public CardDeckHttpRepository(HttpClient http)
    {
        _http = http;
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<List<CardDeckDto>> GetCardDecks()
    {
        var result = await _http.GetAsync($"/api/cardDecks");
        var content = await result.Content.ReadAsStringAsync();

        if (result.IsSuccessStatusCode == false)
            throw new ApplicationException(content);

        var cardDecks = JsonSerializer.Deserialize<List<CardDeckDto>>(content, _options);
        return cardDecks;
    }

    public async Task<CardDeckDto> GetCardDeck(int id)
    {
        var result = await _http.GetAsync($"/api/cardDecks/{id}");
        var content = await result.Content.ReadAsStringAsync();

        if (result.IsSuccessStatusCode == false)
            throw new ApplicationException(content);

        var cardDeck = JsonSerializer.Deserialize<CardDeckDto>(content, _options);
        return cardDeck;
    }


}
