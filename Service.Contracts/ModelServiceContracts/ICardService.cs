using Shared.DataTransferObjects.Card;

namespace Service.Contracts.ModelServiceContracts;

/// <summary>
/// Interface för att hantera de olika Task-metoderna för CardService
/// </summary>
public interface ICardService
{
    /// <summary>
    /// Metod som frågar Repository-lagret om att hämta alla kort som finns i en specifik kortlek.
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla korten från.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Om kortleken finns och det finns kort i kortleken så returneras en lista annars kastar den NotFound.</returns>
    Task<IEnumerable<CardDto>> GetCardsAsync(int cardDeckId, bool trackChanges);

    /// <summary>
    /// Metod som hämtar specifikt kort från en specifik kortlek. 
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta kortet från</param>
    /// <param name="cardId">Id på det kort man vill hämta</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar en DTO på det kort man efterfrågar. Kastar fel om kortleken eller kortet inte finns</returns>
    Task<CardDto> GetCardAsync(int cardDeckId, int cardId, bool trackChanges);
}
