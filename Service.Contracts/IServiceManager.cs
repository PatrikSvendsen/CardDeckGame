using Service.Contracts.ModelServiceContracts;

namespace Service.Contracts;
public interface IServiceManager
{
    ICardDeckService CardDeckService { get; }
    ICardService CardService { get; }
    IHistoryService HistoryService { get; }
}
