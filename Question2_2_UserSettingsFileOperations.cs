using System;
using System.IO;

public class UserSettingsFile
{
    public static void WriteSettingsToFile(string settings, string filePath)
    {
        File.WriteAllText(filePath, settings);
    }

    public static string ReadSettingsFromFile(string filePath)
    {
        return File.ReadAllText(filePath);
    }

    public static void Main()
    {
        string settings = "11111111";  
        string filePath = "user_settings.txt";

        WriteSettingsToFile(settings, filePath);
        Console.WriteLine("Settings saved to file.");

        string savedSettings = ReadSettingsFromFile(filePath);
        Console.WriteLine("Read from file: " + savedSettings);
    }
}
