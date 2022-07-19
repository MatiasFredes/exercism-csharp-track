using LogsLogsLogs;
using System;

// TODO: define the 'LogLevel' enum

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string code = GetCodeLogLine(logLine);

        switch (code)
        {
            case "TRC": return LogLevel.Trace;
            case "DBG": return LogLevel.Debug;
            case "INF": return LogLevel.Info;
            case "WRN": return LogLevel.Warning;
            case "ERR": return LogLevel.Error;
            case "FTL": return LogLevel.Fatal;
            default: return LogLevel.Unknown;
        }
    }

    private static string GetCodeLogLine(string logLine)
    {
        string code = logLine.Split(": ")[0];
        int startIndex = 0;
        int endIndex = code.IndexOf(']');
        return code.Substring(startIndex + 1, ((endIndex - 1) - (startIndex)));
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}

namespace LogsLogsLogs
{
    enum LogLevel
    {
        Trace = 1,
        Debug = 2,
        Info = 4,
        Warning = 5,
        Error = 6,
        Fatal = 42,
        Unknown = 0
    }
}