using Shared.DataTransferObjects.Card;

namespace Shared.DataTransferObjects.History;

public record HistoryDto
{
    public int Id { get; init; }
    public int Round { get; init; }
    public int CardId { get; init; }
    public CardDto Card { get; init; }
};