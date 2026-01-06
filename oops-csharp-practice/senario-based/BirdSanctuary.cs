using System;

// =====================
// Base Class
// =====================
public class Bird
{
    public string Name { get; set; }
    public string Species { get; set; }

    public Bird(string name, string species)
    {
        Name = name;
        Species = species;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Species: {Species}");
    }
}
	
// =====================
// Interfaces
// =====================
public interface IFlyable
{
    void Fly();
}
public interface ISwimmable
{
    void Swim();
}

// =====================
// Derived Classes
// =====================
public class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name, "Eagle") { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is soaring high in the sky.");
    }
}

public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name, "Sparrow") { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying short distances.");
    }
}

public class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name, "Duck") { }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming in the pond.");
    }
}

public class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name, "Penguin") { }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming underwater.");
    }
}

public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name, "Seagull") { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying over the sea.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is floating on water.");
    }
}

// =====================
// Main Program
// =====================
class BirdSanctuary
{
    static void Main()
    {
        // Array of Bird objects (Polymorphism)
        Bird[] birds = new Bird[]
        {
            new Eagle("Rocky"),
            new Sparrow("Chirpy"),
            new Duck("Daffy"),
            new Penguin("Pingu"),
            new Seagull("Sky")
        };

        Console.WriteLine("=== EcoWing Bird Sanctuary ===\n");

        foreach (Bird bird in birds)
        {
            bird.DisplayInfo();

            // Check flying ability
            if (bird is IFlyable flyable)
            {
                flyable.Fly();
            }

            // Check swimming ability
            if (bird is ISwimmable swimmable)
            {
                swimmable.Swim();
            }

            Console.WriteLine("----------------------------");
        }
    }
}
