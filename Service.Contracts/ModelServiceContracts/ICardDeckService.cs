using Shared.DataTransferObjects.CardDeck;

namespace Service.Contracts.ModelServiceContracts;

public interface ICardDeckService
{
    IEnumerable<CardDeckDto> GetAllCardDecks(bool trackChanges);
}
