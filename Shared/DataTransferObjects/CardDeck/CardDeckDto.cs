using Shared.DataTransferObjects.Card;

namespace Shared.DataTransferObjects.CardDeck;

/// <summary>
/// DTO class i form av Record. För att hålla riktiga entiteten borta från att bli manipulerad. 
/// </summary>
public record CardDeckDto()
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int TotalCards { get; init; }
    public List<CardDto> Cards { get; init; }
}