static class LogLine
{
    public static string Message(string logLine)
    {
        string TrimedLogLine = logLine.Trim();
        int LogTypeAndMessageSplitterIndex = TrimedLogLine.IndexOf(":");
        string LogMessage = TrimedLogLine.Substring(LogTypeAndMessageSplitterIndex + 1);
        return LogMessage.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string TrimedLogLine = logLine.Trim();
        int LogTypeAndMessageSplitterIndex = TrimedLogLine.IndexOf(":");
        string LogType = TrimedLogLine.Substring(1, LogTypeAndMessageSplitterIndex - 2);
        return LogType.Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        string TrimedLogLine = logLine.Trim();
        int LogTypeAndMessageSplitterIndex = TrimedLogLine.IndexOf(":");
        string LogType = TrimedLogLine.Substring(1, LogTypeAndMessageSplitterIndex - 2);
        string LogMessage = TrimedLogLine.Substring(LogTypeAndMessageSplitterIndex + 1).Trim();
        return $"{LogMessage} ({LogType.ToLower()})";
    }
}
