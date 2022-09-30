using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;

public class CardRepository : RepositoryBase<Card>, ICardRepository
{
    public CardRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    /// <summary>
    /// Hämtar alla kort från databasen. Sorterar på Id
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar entitet om det finns i databasen annars null.</returns>
    public async Task<IEnumerable<Card>> GetCardsAsync(int cardDeckId, bool trackChanges) =>
    await FindByCondition(cd => cd.CardDeckId.Equals(cardDeckId), trackChanges)
    .OrderBy(cd => cd.Id)
    .ToListAsync();

    /// <summary>
    /// Hämtar enskilt kort från vald kortlek.
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från.</param>
    /// <param name="cardId">Id på det kort man vill hämta.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar entitet om det finns i databasen annars null.</returns>
    public async Task<Card> GetCardAsync(int cardDeckId, int id, bool trackChanges) =>
        await FindByCondition(c => c.CardDeckId.Equals(cardDeckId) && c.Id.Equals(id),
            trackChanges)
        .SingleOrDefaultAsync();


}
