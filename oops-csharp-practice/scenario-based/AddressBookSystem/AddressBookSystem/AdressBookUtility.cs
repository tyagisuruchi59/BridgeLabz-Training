using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookUtility
    {
        private List<Contact> contacts = new List<Contact>();

        // UC-2 Add New Contact (Console input)
        //UC-5 Add multiple contacts
        public void AddContact()
        {
            string choice = "yes";

            while (choice == "yes")

            {
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                // UC7: Duplicate check
                bool isDuplicate = false;

                for (int i = 0; i < contacts.Count; i++)
                {
                    if (contacts[i].FirstName == firstName &&
                        contacts[i].LastName == lastName)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    Console.WriteLine("Duplicate Contact Found. Cannot Add.");
                    return;
                }


                Console.WriteLine("Enter Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();

                Console.WriteLine("Enter State:");
                string state = Console.ReadLine();

                Console.WriteLine("Enter Zip:");
                string zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number:");
                string phone = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                //Create Contact object (composition)
                Contact contact = new Contact()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = phone,
                    Email = email
                };

                contacts.Add(contact);

                Console.WriteLine("New Contact Added Successfully!");
                Console.WriteLine("Do you want to add another contact? (yes/no)"); //UC5
                choice = Console.ReadLine();
            }
        }

        public void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("All Contacts:");
            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Display();
            }
        }
        // UC-3: Edit existing contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name of contact to edit:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name of contact to edit:");
            string lastName = Console.ReadLine();

            Contact found = null;


            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName == firstName && contacts[i].LastName == lastName)
                {
                    found = contacts[i];
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            // Update details
            Console.WriteLine("Editing contact. Press Enter to keep existing value.");

            Console.WriteLine("Current Address: " + found.Address);
            Console.WriteLine("Enter New Address:");
            string address = Console.ReadLine();
            if (address != "") found.Address = address;

            Console.WriteLine("Current City: " + found.City);
            Console.WriteLine("Enter New City:");
            string city = Console.ReadLine();
            if (city != "") found.City = city;

            Console.WriteLine("Current State: " + found.State);
            Console.WriteLine("Enter New State:");
            string state = Console.ReadLine();
            if (state != "") found.State = state;

            Console.WriteLine("Current Zip: " + found.Zip);
            Console.WriteLine("Enter New Zip:");
            string zip = Console.ReadLine();
            if (zip != "") found.Zip = zip;

            Console.WriteLine("Current Phone: " + found.PhoneNumber);
            Console.WriteLine("Enter New Phone:");
            string phone = Console.ReadLine();
            if (phone != "") found.PhoneNumber = phone;

            Console.WriteLine("Current Email: " + found.Email);
            Console.WriteLine("Enter New Email:");
            string email = Console.ReadLine();
            if (email != "") found.Email = email;

            Console.WriteLine("Contact Updated Successfully!");
        }

        // UC4: Delete contact using name
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name of contact to delete:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name of contact to delete:");
            string lastName = Console.ReadLine();

            int index = -1;

            // search contact using for loop
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName == firstName &&
                    contacts[i].LastName == lastName)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contacts.RemoveAt(index);
            Console.WriteLine("Contact Deleted Successfully!");
        }


    }
}