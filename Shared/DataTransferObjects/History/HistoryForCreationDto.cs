namespace Shared.DataTransferObjects.History;

/// <summary>
/// DTO class i form av Record. För att hålla riktiga entiteten borta från att bli manipulerad. 
/// </summary>
public record HistoryForCreationDto
{
    public int Id { get; init; }
    public int Round { get; init; }
    public int CardId { get; init; }
};