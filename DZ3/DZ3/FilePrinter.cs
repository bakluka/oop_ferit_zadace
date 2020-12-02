using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DZ2
{
    class FilePrinter : IPrinter
    {
        string filename;
        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void Print(string to_print)
        {
            using (FileStream fs = File.Create(filename))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(to_print);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
