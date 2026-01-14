using System;

namespace AddressBookSystem
{
    class AddressBookMenu
    {
        //private AddressBookUtility utility = new AddressBookUtility();
        private Dictionary<string, AddressBookUtility> addressBooks =
    new Dictionary<string, AddressBookUtility>(); //UC6


        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAddress Book Menu");
                Console.WriteLine("1. Create Address Book");//UC6
                Console.WriteLine("2. Add Contact"); //UC2
                Console.WriteLine("3. View Contacts");
                Console.WriteLine("4. Edit Contact"); //UC3
                Console.WriteLine("5. Delete Contact"); //UC4
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateAddressBook();  //UC6
                        break;

                    case "2":
                        AddressBookUtility book1 = SelectAddressBook();
                        if (book1 != null) book1.AddContact();
                        break;

                    case "3":
                        AddressBookUtility book2 = SelectAddressBook();
                        if (book2 != null) book2.ViewContacts();
                        break;

                    case "4":
                        AddressBookUtility book3 = SelectAddressBook();
                        if (book3 != null) book3.EditContact();
                        break;

                    case "5":
                        AddressBookUtility book4 = SelectAddressBook();
                        if (book4 != null) book4.DeleteContact();
                        break;

                    /*{
                        case "1":
                            utility.AddContact();
                            break;
                        case "2":
                            utility.ViewContacts();
                            break;
                        case "3":
                            utility.EditContact();
                            break;
                        case "4":
                            utility.DeleteContact();
                            break;*/


                    case "6":
                        Console.WriteLine("Exiting Address Book...");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
        private void CreateAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }

            addressBooks.Add(name, new AddressBookUtility());
            Console.WriteLine("Address Book Created Successfully!");
        }

        private AddressBookUtility SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }

            Console.WriteLine("Address Book Not Found.");
            return null;
        }
    }
}