enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    private static LogLevel Conversion (string LogLevelShort)
    {
        switch (LogLevelShort)
        {
            case "TRC":
                return LogLevel.Trace;
            case "DBG":
                return LogLevel.Debug;
            case "INF":
                return LogLevel.Info;
            case "WRN":
                return LogLevel.Warning;
            case "ERR":
                return LogLevel.Error;
            case "FTL":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        }
    }
    public static LogLevel ParseLogLevel(string logLine)
    {
        return Conversion(logLine.Substring(1, 3));
    }
    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return String.Format("{0}:{1}", ((decimal)logLevel), message);
    }
}
