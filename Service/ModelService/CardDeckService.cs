using Contracts;
using Entities.Models;
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

    public IEnumerable<CardDeck> GetAllCardDecks(bool trackChanges)
    {
        try
        {
            var cardDecks = _repository.CardDeck.GetAllCardDecks(trackChanges);

            return cardDecks;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllCardDecks)} service methdo {ex}");
            throw;
        }
    }
}
