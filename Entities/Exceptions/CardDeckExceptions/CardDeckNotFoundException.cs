namespace Entities.Exceptions.CardDeckExceptions;

public sealed class CardDeckNotFoundException : NotFoundException
{
    public CardDeckNotFoundException(int cardDeckId)
        : base($"The Card Deck with id: {cardDeckId} doesn't exist in the database.")
    {
    }
}
