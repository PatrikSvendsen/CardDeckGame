namespace Contracts;

/// <summary>
/// Ett interface för att hantera de olika metoderna för logging. 
/// </summary>
public interface ILoggerManager
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogDebug(string message);
    void LogError(string message);
}
