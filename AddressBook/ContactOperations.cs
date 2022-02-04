using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactOperations
    {
        public void AddNewContact()
        {
            CreateContacts contacts = new CreateContacts();
            Console.WriteLine("Enter your first name: ");
            contacts.firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            contacts.lastName = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            contacts.address = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter your state: ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter your zip: ");
            contacts.zip = Console.ReadLine();
            Console.WriteLine("Enter your phoneNumber: ");
            contacts.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            contacts.email = Console.ReadLine();

        }
    }
}
