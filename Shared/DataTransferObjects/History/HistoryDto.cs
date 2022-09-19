namespace Shared.DataTransferObjects.History;

//public record HistoryDto
//{
//    public int Id { get; init; }
//    public int Round { get; init; }
//    public int CardId{ get; init; }
//};

public record HistoryDto(int Id, int Round, int CardID);