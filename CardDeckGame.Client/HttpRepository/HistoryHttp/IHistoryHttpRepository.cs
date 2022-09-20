using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.HttpRepository.HistoryHttp;

public interface IHistoryHttpRepository
{
    Task<List<HistoryDto>> GetHistorys();
    Task<HistoryDto> CreateHistory(HistoryForCreationDto history);
}
