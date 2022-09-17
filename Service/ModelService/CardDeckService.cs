using AutoMapper;
using Contracts;
using Service.Contracts.ModelServiceContracts;
using Shared.DataTransferObjects.CardDeck;

namespace Service.ModelService;

internal sealed class CardDeckService : ICardDeckService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CardDeckService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<CardDeckDto> GetAllCardDecks(bool trackChanges)
    {

        var cardDecks = _repository.CardDeck.GetAllCardDecks(trackChanges);
        var cardDecksDto = _mapper.Map<IEnumerable<CardDeckDto>>(cardDecks);

        return cardDecksDto;

    }
}
