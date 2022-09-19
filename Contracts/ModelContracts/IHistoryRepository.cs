using Entities.Models;

namespace Contracts.ModelContracts;

public interface IHistoryRepository
{
    Task<IEnumerable<History>> GetAllHistoryAsync(bool trackChanges);
    Task<History> GetHistoryAsync(int historyId, bool trackChanges);
    void CreateHistory(History history);
}
