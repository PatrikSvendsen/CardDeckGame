using AutoMapper;
using Contracts;
using Entities.Exceptions.CardDeckExceptions;
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

    public async Task<IEnumerable<CardDeckDto>> GetAllCardDecksAsync(bool trackChanges)
    {
        var cardDecks = await _repository.CardDeck.GetAllCardDecksAsync(trackChanges);

        var cardDecksDto = _mapper.Map<IEnumerable<CardDeckDto>>(cardDecks);
        return cardDecksDto;
    }

    public async Task<CardDeckDto> GetCardDeckAsync(int id, bool trackChanges)
    {
        var cardDeck = await _repository.CardDeck.GetCardDeckAsync(id, trackChanges);
        if (cardDeck is null)
        {
            throw new CardDeckNotFoundException(id);
        }

        var cardDeckDto = _mapper.Map<CardDeckDto>(cardDeck);
        
        return cardDeckDto;
    }
}
