namespace Entities.Exceptions.CardExceptions;

/// <summary>
/// Class för att hantera felkoder i systemet. Ärver från NotFoundException. Specifikt för Card-classen
/// </summary>
public sealed class CardNotFoundException : NotFoundException
{
    public CardNotFoundException(int cardId)
        : base($"Card with id: {cardId} doesn't exist in the database.")
    {
    }
}
