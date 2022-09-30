using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;
public class CardDeckRepository : RepositoryBase<CardDeck>, ICardDeckRepository
{
    public CardDeckRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {

    }

    /// <summary>
    /// Hämtar alla kortlekar från databasen sorterat på namn. Gör dessutom lazy loading på Cards.
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden.</param>
    /// <returns>Returnerar en lista med alla kort.</returns>
    public async Task<IEnumerable<CardDeck>> GetAllCardDecksAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Name)
        .Include(e => e.Cards)
        .ToListAsync();

    /// <summary>
    /// Hämtar enskilt kortlek från databasen beroende på int. 
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet som man vill hämta. Gör dessutom lazy loading på Cards.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar enskilt kort om det finns i databasen.</returns>
    public async Task<CardDeck> GetCardDeckAsync(int cardDeckId, bool trackChanges) =>
       await FindByCondition(c => c.Id.Equals(cardDeckId), trackChanges)
        .Include(e => e.Cards)
        .SingleOrDefaultAsync();
}
