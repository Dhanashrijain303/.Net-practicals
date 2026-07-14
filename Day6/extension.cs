using System;

public static class Extension
{
    public static string propercase(this string name)
    {
        return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        
    }
}