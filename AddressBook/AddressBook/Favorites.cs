using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Favorites
    {   
        public string ContactFirstName;
        public string ContactLastName;
        public string ContactAddress;
        public string ContactPhoneNumber;

        public Favorites(string firstName, string lastName, string address, string phoneNumber)
        {
            this.ContactFirstName = firstName;
            this.ContactLastName = lastName;
            this.ContactAddress = address;
            this.ContactPhoneNumber = phoneNumber;
        }
        
        public override string ToString()
        {

            return (ContactFirstName + " " + ContactLastName + " " + ContactAddress + " " + ContactPhoneNumber);
        }
    }
}