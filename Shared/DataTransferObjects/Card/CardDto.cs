namespace Shared.DataTransferObjects.Card;

public record CardDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Suit { get; init; } = string.Empty;
    public int CardDeckId { get; init; }
    public string ImgName { get; init; } = string.Empty;

    public bool CheckBoxIsActive { get; set; } = false;
};