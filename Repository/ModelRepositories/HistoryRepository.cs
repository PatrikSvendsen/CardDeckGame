﻿using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;
public class HistoryRepository : RepositoryBase<History>, IHistoryRepository
{
    public HistoryRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<History>> GetAllHistoryAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Id)
        .ToListAsync();

    public async Task<History> GetHistoryAsync(int historyId, bool trackChanges) =>
       await FindByCondition(c => c.Id.Equals(historyId), trackChanges)
        .SingleOrDefaultAsync();
    
    public void CreateHistory(History history) => Create(history);
}
