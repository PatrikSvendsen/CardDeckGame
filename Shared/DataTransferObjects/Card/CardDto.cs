namespace Shared.DataTransferObjects.Card;

/// <summary>
/// DTO class i form av Record. För att hålla riktiga entiteten borta från att bli manipulerad. 
/// </summary>
public record CardDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Suit { get; init; } = string.Empty;
    public int CardDeckId { get; init; }
    public string ImgName { get; init; } = string.Empty;

    public bool CheckBoxIsActive { get; set; } = false;
};