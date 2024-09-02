namespace TextDataAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Analyzer !!");
            Console.WriteLine("Please enter your directory path");
            string path = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);//convert to directory
            if (!directoryInfo.Exists)
            {
                Console.WriteLine("Folder Not Exist");
                return;
            }
            var files= Directory.GetFiles(path);//return array of files name in the directory
        }
    }
}
