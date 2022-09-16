using Contracts;
using Service.Contracts.ModelServiceContracts;

namespace Service.ModelService;

internal sealed class CardDeckService : ICardDeckService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public CardDeckService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
