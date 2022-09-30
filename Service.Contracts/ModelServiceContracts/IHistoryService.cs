using Shared.DataTransferObjects.History;

namespace Service.Contracts.ModelServiceContracts;

/// <summary>
/// Interface för att hantera de olika Task-metoderna för HistoryService
/// </summary>
public interface IHistoryService
{
    /// <summary>
    /// Metod som frågar Repository-lagret om att hämta all historik från databasen
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>En lista med all historik</returns>
    Task<IEnumerable<HistoryDto>> GetAllHistoryASync(bool trackChanges);

    /// <summary>
    /// Metod som frågar Repository-lagret om att hämta en speicifk historik från databasen.
    /// </summary>
    /// <param name="historyId">Id på den historik man vill hämta.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar en DTO om historiken finns annars kastar den NotFoundException</returns>
    Task<HistoryDto> GetHistoryAsync(int historyId, bool trackChanges);

    /// <summary>
    /// Metod som skapar en historik i databasen baserat på inkommande DTO.
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Om det lyckats skapas en historik så returneras den skapade historiken tillbaka med nytt Id</returns>
    Task<HistoryDto> CreateHistoryAsync(HistoryForCreationDto history);
}
