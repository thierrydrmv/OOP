using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.FileHandling
{
    internal class FileHandlerStream
    {
        public string data { get; set; }
        public string file { get; set; }
        public FileHandlerStream(string location)
        {
            this.file = location;
        }
        public void write_file(string data)
        {
            StreamWriter writer = new StreamWriter(file);
            try
            {
                writer.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally 
            { 
                writer.Close(); 
            }
        }
        public void read_file()
        {
            StreamReader reader = new StreamReader(file);

            try
            {
                data = reader.ReadLine();

                while(data !=null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
