using System;

namespace TychoKlaver.FileOrganizer;

class Program
{
    static void Main(string[] args)
    {
        // Creates a new instance of the class, so static is averted.
        Program program = new Program();
        // Runs the void.
        program.OrganizeFiles();
    }

    public void OrganizeFiles() {
        string homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        // Gets path user enters.
        Console.Write("Enter the relative path from your HOME folder: ");
        string? relativePath = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(relativePath)) {
            System.Console.WriteLine("Invalid input. Please enter a valid path.");
            return;
        }

        string path = Path.Combine(homeDir, relativePath);

        // Checks if directory exists, otherwise return to start.
        if (!Directory.Exists(path)) {
            Console.WriteLine("That folder does not exist..");
            return;
        }

        // Gets all files in path user gave with. 
        string[] files = Directory.GetFiles(path);

        // Loops through all files.
        foreach (string file in files) {
            string extension = Path.GetExtension(file).ToLower();

            if (extension == ".zip")
                continue;

            string folderName = extension switch {
                ".docx" or ".pdf" => "Docs",
                ".xlsx" or ".pptx" => "OfficeResources",
                ".txt" => "TextFiles",
                ".exe" => "Executables",
                ".jpg" or ".jpeg" or ".png" => "Images",
                _ => "Rest"
            };

            string targetFolder = Path.Combine(path, folderName);

            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            string fileName = Path.GetFileName(file);
            string destPath = Path.Combine(targetFolder, fileName);

            if (!File.Exists(destPath))
                File.Move(file, destPath);
        }


        // Visual confirmation that orginization has occured.
        Console.WriteLine("Files are organized!");
    }
}
