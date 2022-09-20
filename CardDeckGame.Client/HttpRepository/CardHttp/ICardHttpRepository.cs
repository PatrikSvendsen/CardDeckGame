using Shared.DataTransferObjects.Card;

namespace CardDeckGame.Client.HttpRepository.CardHttp;

public interface ICardHttpRepository
{
    Task<CardDto> GetCard(int cardDeckId, int cardId);
    Task<List<CardDto>> GetCards(int cardDeckId);
}
