using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public static class FileInfoExtensions
    {
        public static bool IsTxtFile(this FileInfo fileInfo) {
            if (fileInfo.Extension == ".txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCSVFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
