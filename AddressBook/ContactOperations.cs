using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactOperations
    {
        List <CreateContacts> AddressBook = new List<CreateContacts>();

        public CreateContacts InputNewContactDetails()
        {
            CreateContacts contacts = new CreateContacts();
            Console.WriteLine("\n**************************");
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
            Console.WriteLine("**************************\n");
            return contacts;
        }
        public void AddNewContact()
        {
            CreateContacts contacts = new CreateContacts();
            Console.WriteLine("Enter the number of contacts you want add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                contacts = InputNewContactDetails();
                AddressBook.Add(contacts);
            }
        }

    }
}
