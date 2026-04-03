using System;

namespace AddressBookSystem
{
    class AddressBookMenu
    {
        private AddressBookSystemManager systemManager;
        public AddressBookMenu()
        {
        IAddressBookStorage dbStorage = new DatabaseStorage();
        systemManager = new AddressBookSystemManager(dbStorage);
        }

        public async Task ShowMenu()


        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nAddress Book Menu");
                Console.WriteLine("1. Create Address Book");//UC6
                Console.WriteLine("2. Add Contact"); //UC2
                Console.WriteLine("3. View Contacts");
                Console.WriteLine("4. Edit Contact"); //UC3
                Console.WriteLine("5. Delete Contact"); //UC4
                
                Console.WriteLine("6. Search Person by City or State"); //UC8
                Console.WriteLine("7. View Persons by City or State"); //UC9
                Console.WriteLine("8. Count Contacts by City or State"); //UC10
                Console.WriteLine("9. Sort Contacts by Name"); //UC11
                Console.WriteLine("10. Sort Contacts by Location"); // UC12
                Console.WriteLine("11. Write Address Book to File"); //UC13
                Console.WriteLine("12. Read Address Book from File"); //UC13
                Console.WriteLine("13. Write Address Book to CSV"); //UC14
                Console.WriteLine("14. Read Address Book from CSV"); //UC14
                Console.WriteLine("15. Write Address Book to JSON"); //UC15
                Console.WriteLine("16. Read Address Book from JSON"); //UC15
                Console.WriteLine("17. Write Contacts to JSON Server");
                Console.WriteLine("18. Read Contacts from JSON Server");//UC16
                Console.WriteLine("19. Save to Database");
                Console.WriteLine("20. Load from Database");

                Console.WriteLine("0. Exit");




                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        systemManager.CreateAddressBook();  //UC6
                        break;
                    case "2":
                        var book1 = systemManager.SelectAddressBook();
                        if (book1 != null) book1.AddContact();
                        break;

                    case "3":
                        var book2 = systemManager.SelectAddressBook();
                        if (book2 != null) book2.ViewContacts();
                        break;

                    case "4":
                        var book3 = systemManager.SelectAddressBook();
                        if (book3 != null) book3.EditContact();
                        break;

                    case "5":
                        var book4 = systemManager.SelectAddressBook();
                        if (book4 != null) book4.DeleteContact();
                        break;

                    case "6":
                        systemManager.SearchPersonByCityOrState();
                        break;
                    case "7":
                        systemManager.ViewPersonsByCityOrState();
                        break;
                    case "8":
                        systemManager.CountContactsByCityOrState();
                        break;
                    case "9":
                        var book = systemManager.SelectAddressBook();
                        if (book != null)
                            book.SortContactsByName();
                        break;
                    case "10":
                        var book8 = systemManager.SelectAddressBook();
                        if (book8 != null)
                        book8.SortContactsByLocation();
                        break;
                    case "11":
                        var book9 = systemManager.SelectAddressBook();
                        if (book9 != null) await book9.WriteToFile();
                        break;
                    case "12":
                        var book10 = systemManager.SelectAddressBook();
                        if (book10 != null) await book10.ReadFromFile();
                        break;

                    case "13":
                        var book11 = systemManager.SelectAddressBook();
                        if (book11 != null) await book11.WriteToCSV();
                        break;

                    case "14":
                        var book12 = systemManager.SelectAddressBook();
                        if (book12 != null) await book12.ReadFromCSV();
                        break;

                    case "15":
                        var book13 = systemManager.SelectAddressBook();
                        if (book13 != null) await book13.WriteToJson();
                        break;

                    case "16":
                        var book14 = systemManager.SelectAddressBook();
                        if (book14 != null) await book14.ReadFromJson();
                        break;

                    case "17":
                        var book15 = systemManager.SelectAddressBook();
                        if (book15 != null) await book15.WriteToJsonServer();
                        break;

                    case "18":
                        var book16 = systemManager.SelectAddressBook();
                        if (book16 != null) await book16.ReadFromJsonServer();
                        break;

                    case "19":
                        var book17 = systemManager.SelectAddressBook();
                        if (book17 != null) await book17.SaveAsync();
                        break;

                    case "20":
                        var book18 = systemManager.SelectAddressBook();
                        if (book18 != null) await book18.LoadAsync();
                        break;




                    case "0":
                        Console.WriteLine("Exiting Address Book...");
                        running = false;
                        break;
                          

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}
       