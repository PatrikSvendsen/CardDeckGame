using Contracts.ModelContracts;

namespace Contracts;

/// <summary>
/// Ett interface för att hantera de olika repository som finns.  
/// </summary>
public interface IRepositoryManager
{
    ICardDeckRepository CardDeck { get;  }
    ICardRepository Card { get;  }
    IHistoryRepository History { get; }
    Task SaveAsync();
}
