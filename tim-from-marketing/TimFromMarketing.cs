using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        String badge = string.Empty;

        if(id.HasValue)
        {
            badge += $"[{id.Value}] - ";
        }

        badge += $"{name} - ";

        if(department != null)
        {
            badge += $"{department.ToUpper()}";
        }
        else
        {
            badge += $"OWNER";
        }

        return badge;
    }
}
