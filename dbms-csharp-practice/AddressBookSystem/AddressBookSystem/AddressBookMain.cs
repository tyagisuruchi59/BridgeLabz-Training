using System;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static async Task Main() //UC17 for parallel library

        {
            Console.WriteLine("Welcome to Address Book Program on Master Branch"); //UC1
            Console.WriteLine("-----------------------------------------------");

            AddressBookMenu menu = new AddressBookMenu();
            await menu.ShowMenu();
        }
    }
}
