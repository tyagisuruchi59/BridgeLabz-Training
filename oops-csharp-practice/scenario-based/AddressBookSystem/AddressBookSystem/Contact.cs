using System;

namespace AddressBookSystem
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // UC7: Override Equals to check duplicate
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Contact other = obj as Contact;

            if (other == null)
                return false;

            return this.FirstName == other.FirstName &&
                   this.LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }


        public void Display()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address + ", " + City + ", " + State + " - " + Zip);
            Console.WriteLine("Phone: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("----------------------------");
        }
    }
}