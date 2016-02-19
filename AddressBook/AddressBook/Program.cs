using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            ui.UserInput();
            

            Console.ReadLine();
        }

    }
}