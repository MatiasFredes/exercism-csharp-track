using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = string.Empty;
        string[] arr = identifier.Replace(" ", "_").Replace("\0", "CTRL").Split('-');
        
        for(int i = 0; i< arr.Length; i++)
        {
            if (i != 0)
                result += char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            
            else
                result += arr[i];
        }

        foreach(char ch in result)
        {

            if (ch != '_' && (!char.IsLetter(ch) || IsGreek(ch)))
            {
               result = result.Replace(ch.ToString(), string.Empty);
            }
        }

        return result;

    }

    private static bool IsGreek(char ch)
    {
        return ch >= 940 && ch <= 969;
    }
}
