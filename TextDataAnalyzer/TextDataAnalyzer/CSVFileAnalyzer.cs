using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFiles(FileInfo fileInfo)
        {
            //return array of line each line is row contaion number of fields(column)
            string [] Filestring= File.ReadAllLines(fileInfo.FullName);
            //number of elements in first row
           var row= Filestring[0].Split(',');
            AnalysisResults results = new AnalysisResults();
            results.linesCount = row.Length;
            setAnalysisResults(results);
        }
    }
}
