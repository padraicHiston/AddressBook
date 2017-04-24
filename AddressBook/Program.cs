using System;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContactList contactList = new ContactList();

            Console.Write("Type 'A' to add contact or 'Q' to quit: ");

            while (Console.ReadLine().ToUpper().Trim() == "A")
            {
                Contact contact = new Contact();

                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                contactList.AddContact(firstName, lastName, phoneNumber, email);

                Console.Write("Type 'A' to add contact or 'Q' to quit: ");
            }
            
            Console.Write("If you want to search for an existing contact, please enter the contact's last name and hit enter: ");
            string search = Console.ReadLine();
            contactList.ViewContact(search);

            Console.ReadLine();

        }
    }
}
