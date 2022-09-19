﻿namespace Entities.Exceptions.CardExceptions;

public class CardNotFoundException : NotFoundException
{
    public CardNotFoundException(int cardId)
        : base($"Card with id: {cardId} doesn't exist in the database.")
    {
    }
}
