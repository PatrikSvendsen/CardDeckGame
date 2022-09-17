using AutoMapper;
using Contracts;
using Service.Contracts;
using Service.Contracts.ModelServiceContracts;
using Service.ModelService;

namespace Service;
public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICardDeckService> _cardDeckService;
    private readonly Lazy<ICardService> _cardService;
    private readonly Lazy<IHistoryService> _historyService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger,
        IMapper mapper)
    {
        _cardDeckService = new Lazy<ICardDeckService>(() => new
        CardDeckService(repositoryManager, logger, mapper));
        _cardService = new Lazy<ICardService>(() => new
        CardService(repositoryManager, logger, mapper));
        _historyService = new Lazy<IHistoryService>(() => new
        HistoryService(repositoryManager, logger, mapper));
    }

    public ICardDeckService CardDeckService => _cardDeckService.Value;
    public ICardService CardService => _cardService.Value;
    public IHistoryService HistoryService => _historyService.Value;
}
