using System;
using System.Diagnostics;

static class LogLine
{
    public static string Message(string logLine)
    {
            logLine = logLine.Substring(logLine.IndexOf(" ", StringComparison.Ordinal));

        return logLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        logLine = logLine.Substring(logLine.IndexOf("[", StringComparison.Ordinal) +1, logLine.IndexOf("]", StringComparison.Ordinal) - 1);

        return logLine.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
