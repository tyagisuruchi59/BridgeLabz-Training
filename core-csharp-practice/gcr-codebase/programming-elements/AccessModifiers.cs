using System;

namespace AccessModifiers
{
    // Internal class (default visibility inside project)
    internal class BaseClass
    {
        public string userName = "Suru";          // accessible everywhere
        private int pinCode = 1234;                // only inside this class
        protected double salary = 50000;           // base + derived classes
        internal string city = "Agra";              // same project
        protected internal string company = "BridgeLabz"; // project OR child

        // Public method to access private data
        public void DisplayPrivateData()
        {
            Console.WriteLine("Pin Code: " + pinCode);
        }
    }

    // Derived class
    class DerivedClass : BaseClass
    {
        public void ShowAccessibleMembers()
        {
            Console.WriteLine("User Name: " + userName);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Company: " + company);

            // pinCode is private → not accessible
        }
    }

    class EntryPoint
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();

            Console.WriteLine("Name: " + obj.userName);
            Console.WriteLine("City: " + obj.city);
            Console.WriteLine("Company: " + obj.company);

            // Private & protected not accessible here
            // Console.WriteLine(obj.pinCode);
            // Console.WriteLine(obj.salary);

            obj.DisplayPrivateData();

            DerivedClass childObj = new DerivedClass();
            childObj.ShowAccessibleMembers();

            Console.ReadKey();
        }
    }
}
