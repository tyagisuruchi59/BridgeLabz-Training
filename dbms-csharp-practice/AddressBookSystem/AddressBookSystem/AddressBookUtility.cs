using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; // for email and phone validation
using System.IO; //UC13
using System.Globalization;
using CsvHelper; //UC14
using System.Text.Json; //UC15
using System.Net.Http;
using System.Text;//UC16

namespace AddressBookSystem
{
    class AddressBookUtility
    {
        private IAddressBookStorage storage;
        public AddressBookUtility(IAddressBookStorage storage)
        {
            this.storage = storage;
        }


        private List<Contact> contacts = new List<Contact>();

        private static readonly HttpClient client = new HttpClient();


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

                //  PHONE VALIDATION 
                string phone;
                while (true)
                {
                    Console.WriteLine("Enter Phone Number:");
                    phone = Console.ReadLine();

                    if (Regex.IsMatch(phone, @"^\d{10}$"))
                        break;

                    Console.WriteLine("Invalid phone number! Must be exactly 10 digits.");
                }

                //  EMAIL VALIDATION 
                string email;
                while (true)
                {
                    Console.WriteLine("Enter Email:");
                    email = Console.ReadLine();

                    if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        break;

                    Console.WriteLine("Invalid email format!");
                }

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
        // UC8: getter for search across multiple address books
        public List<Contact> GetContacts()
        {
            return contacts;
        }
       
        
        //UC11 -Sort using Collection Library
        public void SortContactsByName()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts to sort.");
                return;
            }

             
            contacts.Sort();

            Console.WriteLine("Contacts Sorted Alphabetically by Name:\n");
            
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine(contacts[i].ToString());
            }
        }
        
        // UC12: Sort contacts by City, State or Zip
        public void SortContactsByLocation()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts to sort.");
                return;
            }

            Console.WriteLine("Sort By:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Zip");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    contacts.Sort((a, b) => a.City.CompareTo(b.City));
                    Console.WriteLine("\nSorted by City:\n");
                    break;

                case "2":
                    contacts.Sort((a, b) => a.State.CompareTo(b.State));
                    Console.WriteLine("\nSorted by State:\n");
                    break;

                case "3":
                    contacts.Sort((a, b) => a.Zip.CompareTo(b.Zip));
                    Console.WriteLine("\nSorted by Zip:\n");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

        // UC13: Write Address Book to File
        public async Task WriteToFile()
        {
            await Task.Run(() =>
            {
                string path = "AddressBook.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        Contact c = contacts[i];
                        writer.WriteLine(c.FirstName + "," +
                                        c.LastName + "," +
                                        c.Address + "," +
                                        c.City + "," +
                                        c.State + "," +
                                        c.Zip + "," +
                                        c.PhoneNumber + "," +
                                        c.Email);
                    }
                }
            });

            Console.WriteLine("Address Book written to file successfully!");
        }

        // UC13: Read Address Book from File
        public async Task ReadFromFile()
        {
            await Task.Run(() =>
            {
                string path = "AddressBook.txt";

                if (!File.Exists(path))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                contacts.Clear();

                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');

                    Contact c = new Contact()
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        Address = data[2],
                        City = data[3],
                        State = data[4],
                        Zip = data[5],
                        PhoneNumber = data[6],
                        Email = data[7]
                    };

                    contacts.Add(c);
                }
            });
            Console.WriteLine("Address Book loaded from file successfully!");
        }

        // UC14: Write Address Book to CSV
        public async Task WriteToCSV()
        {
            await Task.Run(() =>
            {
                using (var writer = new StreamWriter("AddressBook.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(contacts);
                }
            });

            Console.WriteLine("Address Book saved as CSV file!");
        }

        // UC14: Read Address Book from CSV
        public async Task ReadFromCSV()
        {
            await Task.Run(() =>
            {
                if (!File.Exists("AddressBook.csv"))
                {
                    Console.WriteLine("CSV file not found.");
                    return;
                }

                using (var reader = new StreamReader("AddressBook.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    contacts.Clear();
                    var records = csv.GetRecords<Contact>();

                    foreach (var contact in records)
                    {
                        contacts.Add(contact);
                    }
                }
            });

            Console.WriteLine("Address Book loaded from CSV file!");
        }


        // UC15: Write Address Book to JSON
        public async Task WriteToJson()
        {
            await Task.Run(() =>
            {
                string path = "AddressBook.json";

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("[");

                    for (int i = 0; i < contacts.Count; i++)
                    {
                        string json = JsonSerializer.Serialize(contacts[i]);

                        if (i < contacts.Count - 1)
                            writer.WriteLine(json + ",");
                        else
                            writer.WriteLine(json);
                    }

                    writer.WriteLine("]");
                }
            });

            Console.WriteLine("Address Book saved in JSON format!");
        }



        // UC15: Read Address Book from JSON
        public async Task ReadFromJson()
        {
            await Task.Run(() =>
            {
                string path = "AddressBook.json";

                if (!File.Exists(path))
                {
                    Console.WriteLine("JSON file not found.");
                    return;
                }

                string json = File.ReadAllText(path);

                List<Contact> data = JsonSerializer.Deserialize<List<Contact>>(json);

                contacts.Clear();

                for (int i = 0; i < data.Count; i++)
                {
                    contacts.Add(data[i]);
                }
            });

            Console.WriteLine("Address Book loaded from JSON file!");
        }
        // UC16: Send contacts to JSON Server
        public async Task WriteToJsonServer()
        {
            string url = "http://localhost:3000/contacts"; // JSON Server URL

            for (int i = 0; i < contacts.Count; i++)
            {
                string json = JsonSerializer.Serialize(contacts[i]);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("Contact uploaded.");
                else
                    Console.WriteLine("Failed to upload contact.");
            }
        }

        // UC16: Read contacts from JSON Server
        public async Task ReadFromJsonServer()
        {
            string url = "http://localhost:3000/contacts";

            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Failed to fetch data from server.");
                return;
            }

            string json = await response.Content.ReadAsStringAsync();

            List<Contact> serverContacts = JsonSerializer.Deserialize<List<Contact>>(json);

            contacts.Clear();

            for (int i = 0; i < serverContacts.Count; i++)
            {
                contacts.Add(serverContacts[i]);
            }

            Console.WriteLine("Contacts loaded from JSON Server!");
        }

//UC 18 
        public async Task SaveAsync()
        {
            await storage.SaveAsync(contacts);
            Console.WriteLine("Saved Successfully!");
        }

        public async Task LoadAsync()
        {
            contacts = await storage.LoadAsync();
            Console.WriteLine("Loaded Successfully!");
        }

    }
}
      