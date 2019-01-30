using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Induvidual_Task
{
    static class MemoryConverter
    {
        public static string MemoryToString(long memory)
        {
            Memory i = 0;
            while (true)
            {
                if (memory % 2 != 0)
                {
                    ++memory;
                }
                if (memory < 1024)
                {
                    break;
                }
                else
                {
                    memory >>= 10;
                    ++i;
                }
            }
            return memory.ToString() + ' ' + i.ToString();
        }

        public static void GetMemoryOfDirectory(DirectoryInfo directory, ref long totalMemory)
        {
            try
            {
                FileInfo[] files = directory.GetFiles();
                foreach (var file in files)
                {
                    if (file.Extension == ".txt")
                        totalMemory += file.Length;
                }
                foreach (var d in directory.GetDirectories())
                {
                    GetMemoryOfDirectory(d, ref totalMemory);
                }
            }
            catch { }
        }
    }

    enum Memory
    {
        B,
        KB,
        MB,
        GB,
        TB
    }
}
