static class LogLine
{
    public static string Message(string logLine) => logLine.Remove(0, logLine.IndexOf(':')+1).Trim();

    public static string LogLevel(string logLine) => logLine.Trim('[').Remove(logLine.IndexOf(']')-1).ToLower();

    public static string Reformat(string logLine) => LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ')';
}
