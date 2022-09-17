using Entities.Models;

namespace Service.Contracts.ModelServiceContracts;

public interface ICardDeckService
{
    IEnumerable<CardDeck> GetAllCardDecks(bool trackChanges);
}
