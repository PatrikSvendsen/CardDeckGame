namespace Entities.Exceptions.CardDeckExceptions;

/// <summary>
/// Class för att hantera felkoder i systemet. Ärver från NotFoundException. Specifikt för CardDeck-classen
/// </summary>
public sealed class CardDeckNotFoundException : NotFoundException
{
    public CardDeckNotFoundException(int cardDeckId)
        : base($"The Card Deck with id: {cardDeckId} doesn't exist in the database.")
    {
    }
}
