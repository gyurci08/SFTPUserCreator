using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class LogWriter
    {

        public void checkFolder(string path)
        {
            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
                System.IO.Directory.CreateDirectory(path);
        }



        public void createLogFile(String path)
        {
            using (File.Create(path));
        }



        public async void Write(String line, String path)
        {
            


            using (StreamWriter w = File.AppendText(path))
            {
                w.Flush();

              
                    w.WriteLine(line);

            




                w.Close();
            }
        }
    }
}