using Service.Contracts.ModelServiceContracts;

namespace Service.Contracts;

/// <summary>
/// Interface som hanterar alla Service-classer
/// </summary>
public interface IServiceManager
{
    ICardDeckService CardDeckService { get; }
    ICardService CardService { get; }
    IHistoryService HistoryService { get; }
}
