﻿using Contracts;
using Service.Contracts.ModelServiceContracts;

namespace Service.ModelService;

internal sealed class HistoryService : IHistoryService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public HistoryService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}

