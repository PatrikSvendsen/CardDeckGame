using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.HttpRepository.HistoryHttp;

public interface IHistoryHttpRepository
{
    /// <summary>
    /// Skickar en förfrågan till backend-blocket att hämta all data frå databasen
    /// </summary>
    /// <returns>Lista med all historik</returns>
    Task<List<HistoryDto>> GetHistorys();

    /// <summary>
    /// Skickar ett objekt till databasen om att skapa ett objekt
    /// </summary>
    /// <param name="history">Det objekt man vill skapa</param>
    /// <returns>Returnerar nya objektet som har blviit skapat i databasen</returns>
    Task<HistoryDto> CreateHistory(HistoryForCreationDto history);
}
