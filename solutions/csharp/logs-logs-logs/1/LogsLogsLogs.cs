enum LogLevel{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        Dictionary<string, LogLevel> levels = new Dictionary<string, LogLevel>{
            {"TRC", LogLevel.Trace},
            {"DBG", LogLevel.Debug},
            {"INF", LogLevel.Info},
            {"WRN", LogLevel.Warning},
            {"ERR", LogLevel.Error},
            {"FTL", LogLevel.Fatal}
        };
        
        string levelStr = logLine.Substring(1,3);
        LogLevel level;

        if (levels.ContainsKey(levelStr)){
            levels.TryGetValue(levelStr, out level);
        } else{
            level = LogLevel.Unknown;
        }
        
        return level;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) 
        => $"{(int)logLevel}:{message}";
}
