using Entities.Models;

namespace Contracts.ModelContracts;

public interface ICardRepository
{
    /// <summary>
    /// Hämtar alla kort från databasen. Sorterar på Id
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar entitet om det finns i databasen annars null.</returns>
    Task<IEnumerable<Card>> GetCardsAsync(int cardDeckId, bool trackChanges);

    /// <summary>
    /// Hämtar enskilt kort från vald kortlek.
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från.</param>
    /// <param name="cardId">Id på det kort man vill hämta.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar entitet om det finns i databasen annars null.</returns>
    Task<Card> GetCardAsync(int cardDeckId, int cardId, bool trackChanges);
}
