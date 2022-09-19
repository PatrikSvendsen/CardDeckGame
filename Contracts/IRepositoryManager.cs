using Contracts.ModelContracts;

namespace Contracts;

public interface IRepositoryManager
{
    ICardDeckRepository CardDeck { get;  }
    ICardRepository Card { get;  }
    IHistoryRepository History { get; }
    Task SaveAsync();
}
