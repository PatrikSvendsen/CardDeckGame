using Contracts.ModelContracts;
using Entities.Models;

namespace Repository.ModelRepositories;
public class CardDeckRepository : RepositoryBase<CardDeck>, ICardDeckRepository
{
    public CardDeckRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {
    }
}
