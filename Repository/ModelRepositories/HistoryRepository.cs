using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;
public class HistoryRepository : RepositoryBase<History>, IHistoryRepository
{
    public HistoryRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {
    }

    /// <summary>
    /// Hämtar all historia från databasen. Gör även en lazy loading på cards
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar en lista med all historik</returns>
    public async Task<IEnumerable<History>> GetAllHistoryAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Id)
        .Include(e => e.Card) // Lazy loading
        .ToListAsync();

    /// <summary>
    /// Hämtar enskild historik från databasen. Gör även en lazy loading på cards 
    /// </summary>
    /// <param name="historyId"></param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar den enskilda historiken om den finns i databasen</returns>
    public async Task<History> GetHistoryAsync(int historyId, bool trackChanges) =>
       await FindByCondition(c => c.Id.Equals(historyId), trackChanges)
        .Include(e => e.Card) // Lazy loading
        .SingleOrDefaultAsync();

    /// <summary>
    /// Skapar en historik beroende på Entity("history")
    /// </summary>
    /// <param name="history">Entitet som man vill skapa</param>
    public void CreateHistory(History history) => Create(history);
}
