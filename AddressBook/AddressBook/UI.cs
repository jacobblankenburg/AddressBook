using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UI
    {
        
            public void UserInput()
        {
            AdressBookInfo ai = new AdressBookInfo();
            Console.WriteLine("Welcome. Please select what youd like to do:\n Search, Add contact, Add To Favorites, Dispaly Favorites");
            Console.ReadLine();
            //Console.WriteLine("Please select one of the following. ");
            string Userselect = Console.ReadLine();

            switch (Userselect)
            {
                case "search":
                    Console.WriteLine("Who would you like to search for?");
                   
                   
                    
                    break;
                case "add contact":
                    Console.WriteLine("Please enter the contacts info");
                    ai.creatUser();


                    
                    break;
                case "add to favorites":
                    Console.WriteLine("Who would you like to add to your favorites?");
                    break;
                case "display favorites":
                    Console.WriteLine("Favorites:");
                    break;
                

            }
        }

    }
}


