namespace Common
{
    public class FileHelper
    {
        public static void ReadFile(string fileName)
        {
            Console.WriteLine($"Reading from file: {fileName}");
        }
        public static void writeToFile(string fileName)
        {
            Console.WriteLine($"Writing to file: {fileName}");
        }
        public static void DeleteFile(string fileName)
        {
            Console.WriteLine($"Deleting file: {fileName}");
        }

    }
}
