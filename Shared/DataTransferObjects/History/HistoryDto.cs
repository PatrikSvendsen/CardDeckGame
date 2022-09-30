using Shared.DataTransferObjects.Card;

namespace Shared.DataTransferObjects.History;

/// <summary>
/// DTO class i form av Record. För att hålla riktiga entiteten borta från att bli manipulerad. 
/// </summary>
public record HistoryDto
{
    public int Id { get; init; }
    public int Round { get; init; }
    public int CardId { get; init; }
    public CardDto Card { get; init; }
};