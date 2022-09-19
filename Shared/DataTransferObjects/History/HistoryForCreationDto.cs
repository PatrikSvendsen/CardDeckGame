namespace Shared.DataTransferObjects.History;

//public record HistoryForCreationDto
//{
//    public int Id { get; init; }
//    public int Round { get; init; }
//    public int CardId { get; init; }
//};

public record HistoryForCreationDto(int Id, int Round, int CardID);