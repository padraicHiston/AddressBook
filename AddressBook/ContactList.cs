using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class ContactList
    {
        public List<Contact> AllContacts { get; set; }

        public ContactList()
        {
            AllContacts = new List<Contact>();
        }

        public void AddContact(string firstName, string lastName, string phoneNumber, string email)
        {
            Contact contact = new Contact();

            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;

            AllContacts.Add(contact);
        }

        public void ViewContact(string lastName)
        {
            foreach (var contact in AllContacts)
            {
                if (contact.LastName == lastName)
                {
                    Console.WriteLine("First name: " + contact.FirstName);
                    Console.WriteLine("Last name: " + contact.LastName);
                    Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                    Console.WriteLine("Email: " + contact.Email);
                }
            }
        }
    }
}
