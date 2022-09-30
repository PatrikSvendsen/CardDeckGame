using AutoMapper;
using Contracts;
using Entities.Exceptions.HistoryExceptions;
using Entities.Models;
using Service.Contracts.ModelServiceContracts;
using Shared.DataTransferObjects.History;

namespace Service.ModelService;

/// <summary>
/// HistoryService classen injecerar loggern, mappern samt repository-managern. Samt hanterar alla metoder
/// </summary>
internal sealed class HistoryService : IHistoryService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public HistoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<HistoryDto>> GetAllHistoryASync(bool trackChanges)
    {
        var historys = await _repository.History.GetAllHistoryAsync(trackChanges);

        var historysDto = _mapper.Map<IEnumerable<HistoryDto>>(historys);
        return historysDto;
    }

    public async Task<HistoryDto> GetHistoryAsync(int id, bool trackChanges)
    {
        var history = await _repository.History.GetHistoryAsync(id, trackChanges);
        if (history is null)
        {
            throw new HistoryNotFoundException(id);
        }

        var historyDto = _mapper.Map<HistoryDto>(history);
        return historyDto;
    }

    public async Task<HistoryDto> CreateHistoryAsync(HistoryForCreationDto history)
    {
        var historyEntity = _mapper.Map<History>(history);

        _repository.History.CreateHistory(historyEntity);
        await _repository.SaveAsync();

        var historyToReturn = _mapper.Map<HistoryDto>(historyEntity);

        return historyToReturn;
    }
}

