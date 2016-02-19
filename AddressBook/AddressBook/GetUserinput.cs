using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class GetUserinput
    {
       string getuser(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        } 
        public void creatUser()
        {
            string Name;
            string LastName;
            string Address;
            string PhoneNumber;

            Name = getuser("Enter First Name");
            LastName = getuser("Enter Last Name");
            Address = getuser("Enter Address");
            PhoneNumber = getuser("Enter phone Number");

            
        }
    }
}
