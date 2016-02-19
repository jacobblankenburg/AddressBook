using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AdressBookInfo
    {
        List<Contact> addressBook = new List<Contact>();
        FileWritter fw = new FileWritter();
        public AdressBookInfo()
        {
            Contact Jacob = new Contact("Jacob", "Blankenburg", "2603 W lindenwood Ct", "414-943-6565");
            Contact Pillsberry = new Contact("PillsBerry", "DoughBoy", "123 South Roll Road", "414-645-9832");
            addressBook.Add(Jacob);
            addressBook.Add(Pillsberry);
            
        }
        public void WriteTo()
        {
            string output = (" AddressBook " + Environment.NewLine);
            foreach (Contact contact in addressBook)
            {
                output += (Environment.NewLine + " " + contact.ToString());
            }
            fw.WriteToFile("../../List.txt", output);
        }
        public void ReadTo()
        {
            StreamReader file = new StreamReader("../../List.txt");
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
        }
       public void SearchList()
        {
           

        }
        public string GetUserInput(string message)
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

            Name = GetUserInput("Enter First Name");
            LastName = GetUserInput("Enter Last Name");
            Address = GetUserInput("Enter Address");
            PhoneNumber = GetUserInput("Enter phone Number");

            addressBook.Add(new Contact(Name, LastName, Address, PhoneNumber));
        
        }
    }
}
