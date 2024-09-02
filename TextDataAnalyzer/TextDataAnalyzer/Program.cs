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
            // i dont know i need implementation of file analysis for txt or csv
            IFileAnalysis fileAnalysis = null;
            var files= directoryInfo.GetFiles();//return array of files name in the directory
            foreach (var item in files)
            {
                if (item.IsTxtFile())
                {
                    fileAnalysis = new TXTFileAnalyzer();
                    //send file to be analyze in txt class
                    fileAnalysis.AnalyzeFiles(item);
                    //to reach to result cast interface 
                    var result = ((FileAnalyzer)fileAnalysis).getAnalysisResults();

                    Console.WriteLine($"File Name Is : {item.Name} \n");
                    Console.WriteLine($"Words Count Is : {result.wordsCount}\n");
                    Console.WriteLine($"characters Count Is : {result.charactersCount}\n");
                    Console.WriteLine($"Lines Count Is : {result.linesCount}\n");
                    Console.WriteLine("-------------------------------------------------");

                }
                
            }
        }
    }
}
