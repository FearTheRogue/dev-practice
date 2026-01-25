static class LogLine
{
    public static string Message(string logLine)
    {
        int messageStart = logLine.IndexOf("]: ") + 3;
        return logLine.Substring(messageStart).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int messageStart = logLine.IndexOf("[") + 1;
        int messageEnd = logLine.IndexOf("]");
        int messageLength = messageEnd - messageStart;

        return logLine.Substring(messageStart, messageLength).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);

        return $"{message} ({logLevel})";        
    }
}
