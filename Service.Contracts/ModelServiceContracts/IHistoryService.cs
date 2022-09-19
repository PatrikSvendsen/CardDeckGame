using Shared.DataTransferObjects.History;

namespace Service.Contracts.ModelServiceContracts;

public interface IHistoryService
{   
    Task<IEnumerable<HistoryDto>> GetAllHistoryASync(bool trackChanges);
    Task<HistoryDto> GetHistoryAsync(int historyId, bool trackChanges);
    Task<HistoryDto> CreateHistoryAsync(HistoryForCreationDto history);
}
