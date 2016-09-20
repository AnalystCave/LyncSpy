using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyncTracker.Logic
{
    class CSVManager
    {
        string fileName;

        public CSVManager(string fileName, string firstRow)
        {
            this.fileName = fileName;
            if (!File.Exists(fileName))
                WriteLine(firstRow);
        }

        public void WriteLine(string line)
        {
            File.AppendAllLines(fileName, new string[] { line });
        }
    }
}
