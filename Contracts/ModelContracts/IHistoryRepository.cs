using Entities.Models;

namespace Contracts.ModelContracts;

public interface IHistoryRepository
{
    /// <summary>
    /// Hämtar all historia från databasen
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar en lista med all historik</returns>
    Task<IEnumerable<History>> GetAllHistoryAsync(bool trackChanges);

    /// <summary>
    /// Hämtar enskild historik från databasen. 
    /// </summary>
    /// <param name="historyId"></param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar den enskilda historiken om den finns i databasen</returns>
    Task<History> GetHistoryAsync(int historyId, bool trackChanges);

    /// <summary>
    /// Skapar en historik beroende på Entity("history")
    /// </summary>
    /// <param name="history">Entitet som man vill skapa</param>
    void CreateHistory(History history);
}
