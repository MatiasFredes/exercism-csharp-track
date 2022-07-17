using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string logLine, string delimiter)
    {
        return logLine.Split(delimiter)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string logLine, string start, string end )
    {
        int indexStart = logLine.IndexOf(start);
        int indexEnd = logLine.IndexOf(end);
        string message = logLine.Substring(indexStart + start.Length, (indexEnd - (indexStart + start.Length)));
        return message;
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}