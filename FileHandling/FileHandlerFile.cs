using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.FileHandling
{
    internal class FileHandlerFile
    {
        public FileHandlerFile(string data)
        {
            if (File.Exists("test.txt"))
            {
                string readString = File.ReadAllText("test.txt");
                Console.WriteLine(readString);
            }

            if (!File.Exists("test.txt"))
            {
                File.WriteAllText("test.txt", data);
            }
        }
    }
}
