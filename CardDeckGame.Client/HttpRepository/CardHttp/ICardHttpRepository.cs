using Shared.DataTransferObjects.Card;

namespace CardDeckGame.Client.HttpRepository.CardHttp;

public interface ICardHttpRepository
{
    /// <summary>
    /// Skickar en förfrågan till backend-blocket att hämta all data frå databasen tillhörade specifik kortlek
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet man vill hämta alla kort från.</param>
    /// <returns>Lista med all data</returns>
    Task<List<CardDto>> GetCards(int cardDeckId);

    /// <summary>
    /// Skickar en förfrågan till backend-blocket att hämta all data frå databasen.
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet man vill hämta alla kort från.</param>
    /// <param name="cardDeckId">Id på den entitet man vill hämta</param>
    /// <returns>Returnerar vald entitet</returns>
    Task<CardDto> GetCard(int cardDeckId, int cardId);

}
