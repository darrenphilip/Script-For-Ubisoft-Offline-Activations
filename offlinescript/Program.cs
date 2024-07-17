using System;
using System.IO;

class Program
{
    static void Main()
    {
        string username = Environment.UserName;
        string settingsPath = $@"C:\Users\{username}\AppData\Local\Ubisoft Game Launcher\settings.yaml";
        string temp = $@"C:\Users\{username}\AppData\Local\Ubisoft Game Launcher\settings.yaml.temp";

        if (File.Exists(settingsPath) && File.Exists(temp))
        {
            Console.WriteLine("settings.yaml & settings.yaml.temp file exist!");

            File.Delete(temp);
            File.Delete(settingsPath);

            Console.WriteLine("settings.yaml & settings.yaml.temp file removed!");
            Console.WriteLine("Now reopen ubisoft connect and try launching the game again!");
            Console.WriteLine();

            Console.Write("Type 'next' if you have launched the game and closed it: ");
            string nextInput = Console.ReadLine();
            if (nextInput == "next")
            {
                // Open the settings.yaml file in read mode
                string contents = File.ReadAllText(settingsPath);

                string modifiedContents = contents.Replace("offline: false", "offline: true");

                // Open the settings.yaml file in write mode
                File.WriteAllText(settingsPath, modifiedContents);

                Console.WriteLine("settings.yaml file modified successfully!");
                Console.WriteLine("Try launching game now!");
            }
        }
        else
        {
            Console.WriteLine($"settings.yaml/settings.yaml.temp file does not exist in C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\");
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}