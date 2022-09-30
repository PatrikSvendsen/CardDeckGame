namespace Entities.Exceptions;

/// <summary>
/// Abstract class av inbyggda Exception. 
/// </summary>
public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message)
        : base(message) 
    { }
}
