using System;

public class UserSettings
{
    public static bool IsFeatureEnabled(string settings, int feature)
    {
        return settings[feature - 1] == '1';
    }
    
    public static void Main()
    {
        Console.WriteLine(IsFeatureEnabled("00000000", 7));  // will output: False
        Console.WriteLine(IsFeatureEnabled("00000010", 7));  // Will Output: True
        Console.WriteLine(IsFeatureEnabled("11111111", 4));  // WillOutput: True
    }
}
