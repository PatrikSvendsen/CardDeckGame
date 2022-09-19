using Shared.DataTransferObjects.CardDeck;

namespace Service.Contracts.ModelServiceContracts;

public interface ICardDeckService
{
    Task<IEnumerable<CardDeckDto>> GetAllCardDecksAsync(bool trackChanges);
    Task<CardDeckDto> GetCardDeckAsync(int cardDeckId, bool trackChanges);
}
