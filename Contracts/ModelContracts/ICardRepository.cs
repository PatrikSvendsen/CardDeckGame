using Entities.Models;

namespace Contracts.ModelContracts;

public interface ICardRepository
{
    Task<IEnumerable<Card>> GetCardsAsync(int cardDeckId, bool trackChanges);
    Task<Card> GetCardAsync(int cardDeckId, int cardId, bool trackChanges);
}
