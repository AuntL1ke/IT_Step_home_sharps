using System;
using System.IO;

class CmdLine
{
    private static string currentPath = Directory.GetCurrentDirectory();
    private static string previousPath = null;

    public static void ExecuteCommand(string command)
    {
        string[] tokens = command.Split(' ');

        switch (tokens[0].ToLower())
        {
            case "md":
                CreateFolder(tokens[1]);
                break;
            case "rd":
                DeleteFolder(tokens[1]);
                break;
            case "cd":
                ChangeDirectory(tokens[1]);
                break;
            case "dir":
                ListDirectoryContents();
                break;
            case "create":
                CreateTextFile(tokens[1]);
                break;
            case "type":
                ViewFileContents(tokens[1]);
                break;
            case "copy":
                CopyFile(tokens[1], tokens[2]);
                break;
            case "del":
                DeleteFile(tokens[1]);
                break;
            case "append":
                AppendToFile(tokens[1]);
                break;
            case "back":
                GoBack();
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }

    static void CreateFolder(string folderName)
    {
        string fullPath = Path.Combine(currentPath, folderName);
        Directory.CreateDirectory(fullPath);
        Console.WriteLine($"Folder '{fullPath}' created");
    }

    static void DeleteFolder(string folderName)
    {
        string fullPath = Path.Combine(currentPath, folderName);
        if (Directory.Exists(fullPath))
        {
            Directory.Delete(fullPath);
            Console.WriteLine($"Folder '{fullPath}' deleted");
        }
        else
        {
            Console.WriteLine($"Folder '{fullPath}' does not exist");
        }
    }

    static void ChangeDirectory(string folderName)
    {
        string fullPath = Path.Combine(currentPath, folderName);
        if (Directory.Exists(fullPath))
        {
            previousPath = currentPath;
            currentPath = fullPath;
            Console.WriteLine($"Current directory changed to '{fullPath}'");
        }
        else
        {
            Console.WriteLine($"Directory '{fullPath}' does not exist");
        }
    }

    static void GoBack()
    {
        if (previousPath != null)
        {
            currentPath = previousPath;
            previousPath = null;
            Console.WriteLine($"Returned to the previous directory: '{currentPath}'");
        }
        else
        {
            Console.WriteLine("There is no previous directory to go back to.");
        }
    }

    static void ListDirectoryContents()
    {
        string[] files = Directory.GetFiles(currentPath);
        string[] directories = Directory.GetDirectories(currentPath);

        Console.WriteLine($"Files and directories in '{currentPath}':");
        Console.WriteLine("Files:");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        Console.WriteLine("\nDirectories:");
        foreach (string directory in directories)
        {
            Console.WriteLine(directory);
        }
    }

    static void CreateTextFile(string fileName)
    {
        string fullPath = Path.Combine(currentPath, fileName);

        Console.Write($"Enter text for the file '{fullPath}': ");
        string content = Console.ReadLine();

        File.WriteAllText(fullPath, content);
        Console.WriteLine($"Text file '{fullPath}' created");
    }

    static void ViewFileContents(string fileName)
    {
        string fullPath = Path.Combine(currentPath, fileName);
        if (File.Exists(fullPath))
        {
            string content = File.ReadAllText(fullPath);
            Console.WriteLine($"Contents of '{fullPath}':\n{content}");
        }
        else
        {
            Console.WriteLine($"File '{fullPath}' does not exist");
        }
    }

    static void CopyFile(string sourceFileName, string destinationFileName)
    {
        string sourceFullPath = Path.Combine(currentPath, sourceFileName);
        string destinationFullPath = Path.Combine(currentPath, destinationFileName);

        if (File.Exists(sourceFullPath))
        {
            File.Copy(sourceFullPath, destinationFullPath, true);
            Console.WriteLine($"File '{sourceFullPath}' copied to '{destinationFullPath}'");
        }
        else
        {
            Console.WriteLine($"File '{sourceFullPath}' does not exist");
        }
    }

    static void DeleteFile(string fileName)
    {
        string fullPath = Path.Combine(currentPath, fileName);
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
            Console.WriteLine($"File '{fullPath}' deleted");
        }
        else
        {
            Console.WriteLine($"File '{fullPath}' does not exist");
        }
    }

    static void AppendToFile(string fileName)
    {
        string fullPath = Path.Combine(currentPath, fileName);
        if (File.Exists(fullPath))
        {
            Console.Write($"Enter text to append to the file '{fullPath}': ");
            string content = Console.ReadLine();

            File.AppendAllText(fullPath, content);
            Console.WriteLine($"Text appended to '{fullPath}'");
        }
        else
        {
            Console.WriteLine($"File '{fullPath}' does not exist");
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter command (or 'exit' to quit): ");
            string command = Console.ReadLine();

            if (command.ToLower() == "exit")
            {
                break;
            }

            CmdLine.ExecuteCommand(command);
        }
    }
}
