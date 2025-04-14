using System;

namespace MyApp;

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
        // Gets path user enters.
        Console.Write("Enter the path of the folder to organize:");
        string path = Console.ReadLine();

        // Checks if directory exists, otherwise return to start.
        if (!Directory.Exists(path)) {
            Console.WriteLine("That folder does not exist..");
            return;
        }

        // Gets all files in path user gave with. 
        string[] files = Directory.GetFiles(path);

        // Loops through all files.
        foreach (string file in files) {
            // Gets file type of current array index. Returns in lowercase.
            string extension = Path.GetExtension(file).ToLower();
            // If no extension was found, continue.
            if (string.IsNullOrEmpty(extension)) continue;

            // Gets extension name, transforms letters to uppercase and added _FILES.
            string folderName = extension.TrimStart('.').ToUpper() + "_Files";
            // Combines path with folder name to find target folder.
            string targetFolder = Path.Combine(path, folderName);

            // Checks if directory exists, otherwise creates one.
            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            // Gets name of current file.
            string fileName = Path.GetFileName(file);
            // Gets path of destination of file.
            string destPath = Path.Combine(targetFolder, fileName);

            // Checks if file exists already. If not, moves file to needed folder.
            if (!File.Exists(destPath))
                File.Move(file, destPath);
        }

        // Visual confirmation that orginization has occured.
        Console.WriteLine("Files are organized!");
    }
}
