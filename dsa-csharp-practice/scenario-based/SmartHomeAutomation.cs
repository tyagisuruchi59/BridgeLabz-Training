using System;

namespace SmartHomeAutomation
{
    // Interface
    interface IControllable
    {
        void TurnOn();
        void TurnOff();
    }

    // Base Class
    abstract class Appliance : IControllable
    {
        public string Name { get; set; }

        public Appliance(string name)
        {
            Name = name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    // Light Class
    class Light : Appliance
    {
        public Light(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} light is glowing softly.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} light is turned off.");
        }
    }

    // Fan Class
    class Fan : Appliance
    {
        public Fan(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} fan is spinning at medium speed.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} fan is stopped.");
        }
    }

    // AC Class
    class AC : Appliance
    {
        public AC(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} AC is cooling the room to 22°C.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} AC is turned off.");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances =
            {
                new Light("Living Room"),
                new Fan("Bedroom"),
                new AC("Office")
            };

            Console.WriteLine("---- Turning ON Appliances ----");
            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOn();
            }

            Console.WriteLine("\n---- Turning OFF Appliances ----");
            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOff();
            }
        }
    }
}
