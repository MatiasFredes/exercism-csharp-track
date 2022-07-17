using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        // [ERROR]: Stack overflow"
        return logLine.Split("]: ")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.Trim().IndexOf('[');
        int endIndex = logLine.Trim().IndexOf(']');
        string codeError = logLine.Trim().Substring(startIndex + 1, ((endIndex - 1) + startIndex));
        return codeError.ToLower();

    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
