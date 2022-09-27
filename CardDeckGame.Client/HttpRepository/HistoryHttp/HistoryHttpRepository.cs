using Shared.DataTransferObjects.History;
using System.Text;
using System.Text.Json;

namespace CardDeckGame.Client.HttpRepository.HistoryHttp;

public class HistoryHttpRepository : IHistoryHttpRepository
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _options;

    public HistoryHttpRepository(HttpClient http)
    {
        _http = http;
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<HistoryDto> CreateHistory(HistoryForCreationDto historyForCreationDto)
    {
        var history = JsonSerializer.Serialize(historyForCreationDto);
        var requestContent = new StringContent(history, Encoding.UTF8, "application/json");
        var response = await _http.PostAsync("/api/historys", requestContent);
        
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode == false)
        {
            throw new ApplicationException(content);
        }

        var createdHistory = JsonSerializer.Deserialize<HistoryDto>(content, _options);
        return createdHistory;
    }

    public async Task<List<HistoryDto>> GetHistorys()
    {
        var result = await _http.GetAsync("/api/historys");
        var content = await result.Content.ReadAsStringAsync();
        if (result.IsSuccessStatusCode == false)
        {
            throw new ApplicationException(content);
        }

        var historys = JsonSerializer.Deserialize<List<HistoryDto>>(content, _options);
        return historys;
    }
}
