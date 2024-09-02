using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public class TXTFileAnalyzer : FileAnalyzer,IFileAnalysis
    {
        public void AnalyzeFiles(FileInfo fileInfo)
        {
          string fileString= File.ReadAllText(fileInfo.FullName);//read all text take string full path

            AnalysisResults results=new AnalysisResults();
            var words = fileString.Split(new char[] { ' ', '\n', '\r', ',' });

            results.wordsCount= words.Length;
            results.charactersCount = fileString.Length;
            var lines= fileString.Split(new char[] { '\n'});
            results.linesCount = lines.Length;
            setAnalysisResults(results);
        }

    }
}
