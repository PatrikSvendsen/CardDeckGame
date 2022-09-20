namespace Shared.DataTransferObjects.Card;

public record CardDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Suit { get; init; } = string.Empty;
    public int CardDeckId { get; init; }
    public string ImgName { get; init; } = string.Empty;
    public bool CheckBox { get; set; } = false;
};

//public record CardDto(int Id, string Name, string Suit, string ImgName, int CardDeckId, bool CheckBox);