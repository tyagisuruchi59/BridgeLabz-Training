using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookSystemManager
    {
        private IAddressBookStorage storage;
        public Dictionary<string, AddressBookUtility> addressBooks; //UC6
        public AddressBookSystemManager(IAddressBookStorage storage)
        {
            this.storage = storage;
            addressBooks = new Dictionary<string, AddressBookUtility>();
        }

        public void CreateAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book with this name already exists.");
                return;
            }

            addressBooks[name] = new AddressBookUtility(storage);
            Console.WriteLine("Address Book Created Successfully!");
        }

        public AddressBookUtility SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                return addressBooks[name];
            else
            {
                Console.WriteLine("Address Book not found!");
                return null;
            }
        }

        // UC8: Search by City/State across all address books
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("Search by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            string option = Console.ReadLine();

            Console.WriteLine("Enter City or State name:");
            string searchValue = Console.ReadLine();

            bool found = false;

            // convert dictionary to list so we can use index-based for loop
            List<AddressBookUtility> bookList = new List<AddressBookUtility>(addressBooks.Values);

            for (int i = 0; i < bookList.Count; i++)
            {
                List<Contact> contacts = bookList[i].GetContacts();

                for (int j = 0; j < contacts.Count; j++)
                {
                    if (option == "1" &&
                        contacts[j].City.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        contacts[j].Display();
                        found = true;
                    }
                    else if (option == "2" &&
                             contacts[j].State.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        contacts[j].Display();
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found in given City/State.");
            }
        }
        //UC-9 View person by city or state
        public void ViewPersonsByCityOrState()
        {
            // Dictionary: City 
            Dictionary<string, List<Contact>> cityDict =
                new Dictionary<string, List<Contact>>();

            // Dictionary: State 
            Dictionary<string, List<Contact>> stateDict =
                new Dictionary<string, List<Contact>>();

            // Get all address books
            List<AddressBookUtility> bookList =
                new List<AddressBookUtility>(addressBooks.Values);

            // Traverse all address books
            for (int i = 0; i < bookList.Count; i++)
            {
                List<Contact> contacts = bookList[i].GetContacts();

                // Traverse contacts in each address book
                for (int j = 0; j < contacts.Count; j++)
                {
                    Contact contact = contacts[j];

                    // Add contact to City dictionary
                    if (!cityDict.ContainsKey(contact.City))
                    {
                        cityDict[contact.City] = new List<Contact>();
                    }
                    cityDict[contact.City].Add(contact);

                    // Add contact to State dictionary
                    if (!stateDict.ContainsKey(contact.State))
                    {
                        stateDict[contact.State] = new List<Contact>();
                    }
                    stateDict[contact.State].Add(contact);
                }
            }

            
            Console.WriteLine("View by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            string option = Console.ReadLine();

            if (option == "1")
            {
                // Display by City
                List<string> cityKeys = new List<string>(cityDict.Keys);

                for (int i = 0; i < cityKeys.Count; i++)
                {
                    string city = cityKeys[i];
                    Console.WriteLine("\nCity: " + city);

                    List<Contact> cityContacts = cityDict[city];
                    for (int j = 0; j < cityContacts.Count; j++)
                    {
                        cityContacts[j].Display();
                    }
                }
            }
            else if (option == "2")
            {
                // Display by State
                List<string> stateKeys = new List<string>(stateDict.Keys);

                for (int i = 0; i < stateKeys.Count; i++)
                {
                    string state = stateKeys[i];
                    Console.WriteLine("\nState: " + state);

                    List<Contact> stateContacts = stateDict[state];
                    for (int j = 0; j < stateContacts.Count; j++)
                    {
                        stateContacts[j].Display();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        //UC10 CountContact By city or state
        public void CountContactsByCityOrState()
        {
            // Dictionary to store City -> Count
            Dictionary<string, int> cityCount =
                new Dictionary<string, int>();

            // Dictionary to store State -> Count
            Dictionary<string, int> stateCount =
                new Dictionary<string, int>();

            // Get all address books
            List<AddressBookUtility> bookList =
                new List<AddressBookUtility>(addressBooks.Values);

            // Traverse all address books
            for (int i = 0; i < bookList.Count; i++)
            {
                List<Contact> contacts = bookList[i].GetContacts();

                // Traverse contacts
                for (int j = 0; j < contacts.Count; j++)
                {
                    Contact contact = contacts[j];

                    // Count by City
                    if (cityCount.ContainsKey(contact.City))
                    {
                        cityCount[contact.City]++;
                    }
                    else
                    {
                        cityCount[contact.City] = 1;
                    }

                    // Count by State
                    if (stateCount.ContainsKey(contact.State))
                    {
                        stateCount[contact.State]++;
                    }
                    else
                    {
                        stateCount[contact.State] = 1;
                    }
                }
            }

           
            Console.WriteLine("Count by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            string option = Console.ReadLine();

            if (option == "1")
            {
                List<string> cityKeys = new List<string>(cityCount.Keys);

                for (int i = 0; i < cityKeys.Count; i++)
                {
                    string city = cityKeys[i];
                    Console.WriteLine("City: " + city + " -> " + cityCount[city] + " persons");
                }
            }
            else if (option == "2")
            {
                List<string> stateKeys = new List<string>(stateCount.Keys);

                for (int i = 0; i < stateKeys.Count; i++)
                {
                    string state = stateKeys[i];
                    Console.WriteLine("State: " + state + " -> " + stateCount[state] + " persons");
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }


    }
}