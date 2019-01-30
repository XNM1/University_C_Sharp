using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Induvidual_Task
{
    static class Saver
    {
        public static void SaveReport(string filePath, Searcher searcher)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine("----------------------Searcher 1.0 Report-----------------------");
                writer.WriteLine("Directory: " + searcher.DirectoryPath);
                writer.WriteLine("Search Text: " + searcher.Pattern);
                writer.WriteLine("-----------------------------Files------------------------------");
                foreach (var item in searcher.FilesFound)
                {
                    writer.WriteLine("FileName: " + item.Name);
                    writer.WriteLine("FullPath: " + item.FullName);
                    writer.WriteLine("Size: " + item.Length + " B");
                    writer.WriteLine("-----");
                }
            }
        }
    }
}
