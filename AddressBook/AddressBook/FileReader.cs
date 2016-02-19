using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileReader
    {
        public string fileName;

        public string ReadFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string text = reader.ReadToEnd();
            reader.Close();
            return text; 
        }
    }
}
