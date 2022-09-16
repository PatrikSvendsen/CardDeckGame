using Contracts.ModelContracts;
using Entities.Models;

namespace Repository.ModelRepositories;
public class HistoryRepository : RepositoryBase<History>, IHistoryRepository
{
    public HistoryRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {
    }
}
