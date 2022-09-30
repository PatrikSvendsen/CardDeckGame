using Shared.DataTransferObjects.Card;
using System.Text.Json;

namespace CardDeckGame.Client.HttpRepository.CardHttp;

public class CardHttpRepository : ICardHttpRepository
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _options;

    public CardHttpRepository(HttpClient http)
    {
        _http = http;
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<CardDto> GetCard(int cardDeckId, int cardId)
    {
        var result = await _http.GetAsync($"/api/cardDecks/{cardDeckId}/cards/{cardId}");
        var content = await result.Content.ReadAsStringAsync();

        if (result.IsSuccessStatusCode == false)
            throw new ApplicationException(content);

        var card = JsonSerializer.Deserialize<CardDto>(content, _options);
        return card;
    }

    public async Task<List<CardDto>> GetCards(int cardDeckId)
    {
        var result = await _http.GetAsync($"/api/cardDecks/{cardDeckId}/cards");
        var content = await result.Content.ReadAsStringAsync();

        if (result.IsSuccessStatusCode == false)
            throw new ApplicationException(content);

        var cards = JsonSerializer.Deserialize<List<CardDto>>(content, _options);
        return cards;
    }
}
