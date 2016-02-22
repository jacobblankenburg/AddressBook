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
        List<Favorites> ContactFavorites = new List<Favorites>();
        FileWritter fw = new FileWritter();
        

        public AdressBookInfo()
        {
            Contact Jacob = new Contact("Jacob", "Blankenburg", "2603 W lindenwood Ct", "414-943-6565");
            Contact Pillsberry = new Contact("PillsBerry", "DoughBoy", "123 South Roll Road", "414-645-9832");
            Favorites fav1 = new Favorites("Jacob", "Blankenburg", "2603 W lindenwood Ct", "414-943-6565");
            addressBook.Add(Jacob);
            addressBook.Add(Pillsberry);
            ContactFavorites.Add(fav1);
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
        public void WriteToFavorites()
        {
            string output = ("Favorites " + Environment.NewLine);
            foreach (Favorites favs in ContactFavorites)
            {
                output += (Environment.NewLine + " " + favs.ToString());
            }
            fw.WriteToFile("../../Favorites.txt", output);
        }
        public void ReadTo()
        {
            StreamReader file = new StreamReader("../../List.txt");
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
        }
        public void readFavorites()
        {
            StreamReader file = new StreamReader("../../Favorites.txt");
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
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
        public void SearchUser(string contact)
        {
            for (int i = 0; i < addressBook.Count; i++)
            {
                Contact search = addressBook[i];
                string SearchName = search.FirstName;
                if (addressBook.Equals(contact))
                {
                    Console.WriteLine(search.FirstName);
                    Console.WriteLine(search.LastName);
                    Console.WriteLine(search.Address);
                    Console.WriteLine(search.PhoneNumber);
                }
                Console.WriteLine(SearchName);
            }
        }

        public void AddToFavorites()
        {
            Console.WriteLine("Enter FirstName");
            string Namef = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            string Namel = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string ContactAddress = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string contactPhoneNum = Console.ReadLine();

            Favorites Favoriteslist = new Favorites(Namef.ToString(), Namel.ToString(), ContactAddress.ToString(), contactPhoneNum.ToString());
            ContactFavorites.Add(Favoriteslist);
            
        }

       
        public void UserInput()
        {

                Console.WriteLine("Please select what youd like to do:\n Search, Add contact, Add To Favorites, Dispaly Favorites");
                Console.ReadLine();
                string Userselect = Console.ReadLine();

                switch (Userselect)
                {
                    case "search":
                        Console.WriteLine("Contacts:");
                        SearchUser("");
                        break;

                    case "add contact":
                        Console.WriteLine("Please enter the contacts info");
                        creatUser();
                        break;

                    case "add to favorites":
                        Console.WriteLine("Who would you like to add to your favorites?");
                        AddToFavorites();
                        break;

                    case "display favorites":
                        Console.WriteLine("Favorites:");
                        readFavorites();
                        break;
                }

        }
    }
}
