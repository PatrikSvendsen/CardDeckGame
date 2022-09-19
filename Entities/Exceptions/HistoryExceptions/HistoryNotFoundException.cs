namespace Entities.Exceptions.HistoryExceptions;

public class HistoryNotFoundException : NotFoundException
{
    public HistoryNotFoundException(int id) 
        : base($"History with this id: {id} cannot be found the database")
    {
    }
}
