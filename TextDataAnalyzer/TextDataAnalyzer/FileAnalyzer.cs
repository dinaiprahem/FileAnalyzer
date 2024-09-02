using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public class FileAnalyzer
    {
       private AnalysisResults _results ;
        public void setAnalysisResults(AnalysisResults results)
        {
            _results = results;
        }
        public AnalysisResults getAnalysisResults()
        {
            return _results;
        }



    }
}
