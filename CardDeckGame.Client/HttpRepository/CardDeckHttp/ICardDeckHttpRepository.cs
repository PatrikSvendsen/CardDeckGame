using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.Client.HttpRepository.CardDeckHttp;

public interface ICardDeckHttpRepository
{
    /// <summary>
    /// Skickar en förfrågan till backend-blocket att hämta all data frå databasen.
    /// </summary>
    /// <returns>Returnerar data och deserializar om det.</returns>
    Task<List<CardDeckDto>> GetCardDecks();

    /// <summary>
    /// Skickar en förfrågan till backend-blocket att hämta data med specifikt Id
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet man vill hämta</param>
    /// <returns>Vald object från databasen och deserializar om det.</returns>
    Task<CardDeckDto> GetCardDeck(int cardDeckId);
}
