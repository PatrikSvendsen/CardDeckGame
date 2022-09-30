using Shared.DataTransferObjects.CardDeck;

namespace Service.Contracts.ModelServiceContracts;

/// <summary>
/// Interface för att hantera de olika Task-metoderna för CardDeckService
/// </summary>
public interface ICardDeckService
{
    /// <summary>
    /// Metod som frågar Repository-lagret om att hämta alla kortlekar från databasen. Mappar sedan om till en DTO.
    /// </summary>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>En lista med alla kortlekar</returns>
    Task<IEnumerable<CardDeckDto>> GetAllCardDecksAsync(bool trackChanges);

    /// <summary>
    /// Metod som frågar Repository-lagret om att hämta en specifik kortlek från databasen. Mappar sedan om till en DTO
    /// </summary>
    /// <param name="cardDeckId">Id på den entitet som skall hämtas.</param>
    /// <param name="trackChanges">Boolean om man vill ha trackChanges på metoden</param>
    /// <returns>Returnerar en CardDeckDto om kortleken finns i databasen annars kostar den ett NotFoundException.</returns>
    Task<CardDeckDto> GetCardDeckByIdAsync(int cardDeckId, bool trackChanges);
}
