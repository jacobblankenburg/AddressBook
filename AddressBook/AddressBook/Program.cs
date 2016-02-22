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
            AdressBookInfo abi = new AdressBookInfo();
            abi.UserInput();
            abi.WriteTo();
            abi.WriteToFavorites();
            Console.ReadLine();
            abi.ReadTo();
            abi.readFavorites();

            Console.ReadLine();
        }

    }
}