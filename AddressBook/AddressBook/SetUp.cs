using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class SetUp
    {
        protected string Name;
        protected string LastName;
        protected string Address;
        protected int PhoneNum;

        public SetUp(string name, string lastname, string address, int num)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Address = address;
            this.PhoneNum = num;

        }
        public virtual string FirstName
        {
            get
            {
                return Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public virtual string PersonLastName
        {
            get
            {
                return LastName;
            }
            set
            {
                this.LastName = value;
            }
        }
        public virtual string PersonsAddress
        {
            get
            {
                return Address;
            }
            set
            {
                this.Address = value;
            }
        }
        public virtual int PersonPhoneNum
        {
            get
            {
                return PhoneNum;
            }
            set
            {
                this.PhoneNum = value;
            }
        }
    }

}

