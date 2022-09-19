using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;
public class CardDeckRepository : RepositoryBase<CardDeck>, ICardDeckRepository
{
    public CardDeckRepository(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {

    }

    public async Task<IEnumerable<CardDeck>> GetAllCardDecksAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Name)
        .ToListAsync();

    public async Task<CardDeck> GetCardDeckAsync(int cardDeckId, bool trackChanges) =>
       await FindByCondition(c => c.Id.Equals(cardDeckId), trackChanges)
        .SingleOrDefaultAsync();
}
