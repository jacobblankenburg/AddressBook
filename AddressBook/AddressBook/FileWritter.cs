using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
    public class FileWritter
    {
        public void WriteToFile(string filePath, string message)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(message);
            }
        }
    }
}
