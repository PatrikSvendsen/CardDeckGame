using Contracts;
using Contracts.ModelContracts;
using Repository.ModelRepositories;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<ICardDeckRepository> _cardDeckRepository;
    private readonly Lazy<ICardRepository> _cardRepository;
    private readonly Lazy<IHistoryRepository> _historyRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;

        _cardDeckRepository = new Lazy<ICardDeckRepository>(() => new
        CardDeckRepository(repositoryContext));

        _cardRepository = new Lazy<ICardRepository>(() => new
        CardRepository(repositoryContext));

        _historyRepository = new Lazy<IHistoryRepository>(() => new
        HistoryRepository(repositoryContext));
    }


    public ICardDeckRepository CardDeck => _cardDeckRepository.Value;
    public ICardRepository Card => _cardRepository.Value;
    public IHistoryRepository History => _historyRepository.Value;

    public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}
