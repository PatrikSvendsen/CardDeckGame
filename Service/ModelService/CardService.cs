using AutoMapper;
using Contracts;
using Entities.Exceptions.CardDeckExceptions;
using Entities.Exceptions.CardExceptions;
using Service.Contracts.ModelServiceContracts;
using Shared.DataTransferObjects.Card;

namespace Service.ModelService;

internal sealed class CardService : ICardService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CardService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<CardDto> GetCardAsync(int cardDeckId, int id, bool trackChanges)
    {
        var cardDeck = await _repository.CardDeck.GetCardDeckAsync(cardDeckId, trackChanges);
        if (cardDeck is null)
        {
            throw new CardDeckNotFoundException(cardDeckId);
        }

        var cardDb = _repository.Card.GetCardAsync(cardDeckId, id, trackChanges);
        if (cardDb is null)
        {
            throw new CardNotFoundException(id);
        }

        var card = _mapper.Map<CardDto>(cardDb);
        return card;
    }

    public async Task<IEnumerable<CardDto>> GetCardsAsync(int cardDeckId, bool trackChanges)
    {
        var cardDeck = await _repository.CardDeck.GetCardDeckAsync(cardDeckId, trackChanges);
        if (cardDeck is null)
        {
            throw new CardDeckNotFoundException(cardDeckId);
        }

        var cardsFromDb = _repository.Card.GetCardsAsync(cardDeckId, trackChanges);
        var cardsDto = _mapper.Map<IEnumerable<CardDto>>(cardsFromDb);

        return cardsDto;
    }
}
