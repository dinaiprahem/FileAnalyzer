﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public interface IFileAnalysis
    {
         void AnalyzeFiles(FileInfo fileInfo);
        
    }
}
