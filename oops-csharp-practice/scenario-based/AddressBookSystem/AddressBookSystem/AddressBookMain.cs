using System;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program on Master Branch"); //UC1
            Console.WriteLine("-----------------------------------------------");

            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}