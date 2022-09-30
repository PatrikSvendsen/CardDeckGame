using Entities.Models;

namespace Contracts.ModelContracts;

public interface ICardDeckRepository
{
    /// <summary>
    /// Hämtar alla kortlekar från databasen sorterat på namn. Gör dessutom lazy loading på Cards.
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden.</param>
    /// <returns>Returnerar en lista med alla kort.</returns>
    Task<IEnumerable<CardDeck>> GetAllCardDecksAsync(bool trackChanges);

    /// <summary>
    /// Hämtar enskilt kortlek från databasen beroende på int. 
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet som man vill hämta. Gör dessutom lazy loading på Cards.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar enskilt kort om det finns i databasen.</returns>
    Task<CardDeck> GetCardDeckAsync(int cardDeckId, bool trackChanges);
}
