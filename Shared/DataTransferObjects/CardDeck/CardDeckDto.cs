using Shared.DataTransferObjects.Card;

namespace Shared.DataTransferObjects.CardDeck;

//public record CardDeckDto(int Id, string Name, int TotalCards, List<CardDto> Cards);

public record CardDeckDto()
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int TotalCards { get; init; }
    public List<CardDto> Cards { get; init; }
}