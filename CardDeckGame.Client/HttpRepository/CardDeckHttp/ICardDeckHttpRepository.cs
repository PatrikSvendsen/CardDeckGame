using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.Client.HttpRepository.CardDeckHttp;

public interface ICardDeckHttpRepository
{
    Task<List<CardDeckDto>> GetCardDecks();
    Task<CardDeckDto> GetCardDeck(int cardDeckId);
}
