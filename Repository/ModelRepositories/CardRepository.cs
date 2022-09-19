using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.ModelRepositories;

public class CardRepository : RepositoryBase<Card>, ICardRepository
{
    public CardRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public async Task<Card> GetCardAsync(int cardDeckId, int id, bool trackChanges) =>
        await FindByCondition(c => c.CardDeckId.Equals(cardDeckId) && c.Id.Equals(id),
            trackChanges)
        .SingleOrDefaultAsync();

    public async Task<IEnumerable<Card>> GetCardsAsync(int cardDeckId, bool trackChanges) =>
        await FindByCondition(cd => cd.CardDeckId.Equals(cardDeckId), trackChanges)
        .OrderBy(cd => cd.Id)
        .ToListAsync();
}
