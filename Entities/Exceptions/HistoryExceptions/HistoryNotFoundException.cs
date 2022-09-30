namespace Entities.Exceptions.HistoryExceptions;

/// <summary>
/// Class för att hantera felkoder i systemet. Ärver från NotFoundException. Specifikt för Hisotry-classen
/// </summary>
public sealed class HistoryNotFoundException : NotFoundException
{
    public HistoryNotFoundException(int id) 
        : base($"History with this id: {id} cannot be found the database")
    {
    }
}
