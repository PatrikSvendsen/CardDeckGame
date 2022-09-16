using Contracts.ModelContracts;
using Entities.Models;

namespace Repository.ModelRepositories;

public class CardRepository : RepositoryBase<Card>, ICardRepository
{
    public CardRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {

    }
}
