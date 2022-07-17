using System;
using System.Collections.Generic;

public static class Languages
{
    
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>() { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        return (languages.Count > 0 && languages.Count <= 3) && (languages[0] == "C#" || languages[1] == "C#");
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        Dictionary<string, int> cache = new Dictionary<string, int>();
        foreach (var language in languages)
        {
            if (cache.ContainsKey(language))
            {
                cache[language] += 1;
            }
            else
            {
                cache[language] = 1;
            }
        }

        foreach (var values in cache.Values)
        {
            if (values > 1)
                return false;
        }

        return true;
    }
}
