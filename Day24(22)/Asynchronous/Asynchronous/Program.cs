using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Specify the path to your file
        string filePath = "C:\\Users\\Rahul vv\\Documents\\GitHub\\QuestTraining\\Day24(22)\\Test.txt";

        try
        {
            // Read the contents of the file asynchronously
            string fileContents = await File.ReadAllTextAsync(filePath);

            // Print the contents to the console
            Console.WriteLine("File Contents:");
            Console.WriteLine(fileContents);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to access this file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
