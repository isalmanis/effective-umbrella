namespace Umbrella.Services;

public class SimpleLogger
{
    private const string LogDirectory = "LogFiles";
    private readonly string _logFilePath;

    public SimpleLogger()
    {
        if (!Directory.Exists(LogDirectory))
        {
            Directory.CreateDirectory(LogDirectory);
        }
        _logFilePath = Path.Combine(LogDirectory, $"log_{DateTime.Now:yyyyMMdd}.txt");
    }

    public void LogInfo(string message) => Log(LogLevel.Info, message);
    public void LogWarn(string message) => Log(LogLevel.Warn, message);
    public void LogError(string message) => Log(LogLevel.Error, message);
    
    private void Log(LogLevel level, string message)
    {
        if (!File.Exists(_logFilePath))
        {
            using (File.Create(_logFilePath)) { }
        }

        Console.WriteLine($"{DateTime.Now:HH:mm:ss} - {level} - {message}");
        File.AppendAllText(_logFilePath, $"{DateTime.Now:HH:mm:ss} - {level} - {message}\n");
    }
}

public enum LogLevel
{
    Info,
    Warn,
    Error
}