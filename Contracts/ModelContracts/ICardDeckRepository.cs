using Entities.Models;

namespace Contracts.ModelContracts;
public interface ICardDeckRepository
{
    IEnumerable<CardDeck> GetAllCardDecks(bool trackChanges);
}
