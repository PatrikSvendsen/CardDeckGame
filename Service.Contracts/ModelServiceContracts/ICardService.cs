using Shared.DataTransferObjects.Card;

namespace Service.Contracts.ModelServiceContracts;

public interface ICardService
{
    Task<IEnumerable<CardDto>> GetCardsAsync(int cardDeckId, bool trackChanges);
    Task<CardDto> GetCardAsync(int cardDeckId, int cardId, bool trackChanges);
}
