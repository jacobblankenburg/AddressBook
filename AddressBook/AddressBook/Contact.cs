using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string PhoneNumber;

        public Contact(string firstName, string lastName, string address, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return (FirstName + " " + LastName + " " + Address + " " + PhoneNumber);
        }
    }
}
