using Entities.Models;

namespace Contracts.ModelContracts;

public interface ICardDeckRepository
{
    Task<IEnumerable<CardDeck>> GetAllCardDecksAsync(bool trackChanges);
    Task<CardDeck> GetCardDeckAsync(int cardDeckId, bool trackChanges);
}
