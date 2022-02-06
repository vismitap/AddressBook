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
        //CreateContacts contacts = new CreateContacts();
        public CreateContacts InputNewContactDetails(CreateContacts contacts)
        {
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
        public CreateContacts AddNewContact(CreateContacts contacts)
        {
            Console.WriteLine("Enter the number of contacts you want add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                contacts = InputNewContactDetails(contacts);
                AddressBook.Add(contacts);
            }
            return contacts;
        }

        public CreateContacts EditContact(CreateContacts contacts)
        {
            string newVal;
            if(contacts.Equals(null))
            {
                Console.WriteLine("Please Add a contact first! Records cannot be updated.");
            }
            else
            {
                Console.WriteLine("Enter\n" +
                "1 to update firstName\n" +
                "2 to update lastName\n" +
                "3 to update address\n" +
                "4 to update city\n" +
                "5 to update state\n" +
                "6 to update zip\n" +
                "7 to update phoneNumber\n" +
                "8 to update email id\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter new value for firstName: ");
                        newVal = Console.ReadLine();
                        contacts.firstName = newVal;
                        break;

                    case 2:
                        Console.WriteLine("Enter new value for lastName: ");
                        newVal = Console.ReadLine();
                        contacts.lastName = newVal;
                        break;

                    case 3:
                        Console.WriteLine("Enter new value for address: ");
                        newVal = Console.ReadLine();
                        contacts.address = newVal;
                        break;

                    case 4:
                        Console.WriteLine("Enter new value for city: ");
                        newVal = Console.ReadLine();
                        contacts.city = newVal;
                        break;

                    case 5:
                        Console.WriteLine("Enter new value for state: ");
                        newVal = Console.ReadLine();
                        contacts.state = newVal;
                        break;

                    case 6:
                        Console.WriteLine("Enter new value for zip: ");
                        newVal = Console.ReadLine();
                        contacts.zip = newVal;
                        break;

                    case 7:
                        Console.WriteLine("Enter new value for phoneNumber: ");
                        newVal = Console.ReadLine();
                        contacts.phoneNumber = newVal;
                        break;

                    case 8:
                        Console.WriteLine("Enter new value for email id: ");
                        newVal = Console.ReadLine();
                        contacts.email = newVal;
                        break;

                    default:
                        Console.WriteLine("Invalid option\n");
                        break;
                }

            }

            Console.WriteLine(contacts.firstName + " " + contacts.lastName);
            return contacts;
        }

        public CreateContacts DeletePersonDetails(CreateContacts contacts)
        {
            Console.WriteLine("Enter the firstName: ");
            string fName = Console.ReadLine();

            if(contacts.firstName == fName)
            {
                AddressBook.Remove(contacts);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine(fName + " not present!");
            }

            return contacts;
        }

        public void Display(CreateContacts contacts)
        {
            Console.WriteLine("First Name :" + contacts.firstName);
            Console.WriteLine("Last Name  :" + contacts.lastName);
            Console.WriteLine("Address    :" + contacts.address);
            Console.WriteLine("City       :" + contacts.city);
            Console.WriteLine("State      :" + contacts.state);
            Console.WriteLine("Zip        :" + contacts.zip);
            Console.WriteLine("Phonenumber :" + contacts.phoneNumber);
            Console.WriteLine("Email :" + contacts.email);
        }

        public void ViewAll()
        {
            AddressBook.ForEach(Display);
        }

    }
}
