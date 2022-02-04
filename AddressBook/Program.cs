using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AddressBook problem");
            ContactOperations operations = new ContactOperations();
            CreateContacts contacts = new CreateContacts();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter\n" +
                    "0 to Exit\n" +
                    "1 to Add new Contact\n" +
                    "2 to Update Existing Contact\n" +
                    "3 to Delete Existing Contact\n" +
                    "4 to Display\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        flag = false;
                        break; 

                    case 1:
                        operations.AddNewContact(contacts);
                        break;

                    case 2:
                        operations.EditContact(contacts);
                        break;

                    case 3:
                        operations.DeletePersonDetails(contacts);
                        break;

                    case 4:
                        operations.Display(contacts);
                        break;

                }
            }
           

        }
    }
}
