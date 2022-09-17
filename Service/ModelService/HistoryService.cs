using AutoMapper;
using Contracts;
using Service.Contracts.ModelServiceContracts;

namespace Service.ModelService;

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
}

