using System;
using System.Collections.Generic;
using System;

public class ActivityLog
{
    private List<string> logs = new List<string>();

    public void Add(string action)
    {
        logs.Add(
            DateTime.Now.ToString("g")
            + " - "
            + action);
    }

    public List<string> GetRecentActions()
    {
        int start = Math.Max(0, logs.Count - 10);
        List<string> recent = new List<string>();

        for (int i = start; i < logs.Count; i++)
            recent.Add(logs[i]);

        return recent;
    }

    public string GetLogText()
    {
        if (logs.Count == 0)
            return "No activity recorded.";

        return string.Join(
            Environment.NewLine,
            GetRecentActions());
    }
}
