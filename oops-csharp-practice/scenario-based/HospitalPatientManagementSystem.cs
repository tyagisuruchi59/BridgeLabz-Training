using System;

// Abstraction
interface IPayable
{
    double CalculateBill();
}

// Base Class
abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    public int PatientId { get { return patientId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }

    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    // Polymorphic Method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}

// Inheritance
class InPatient : Patient, IPayable
{
    private int days;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        this.days = days;
        dailyCharge = charge;
    }

    public override double CalculateBill()
    {
        return days * dailyCharge;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: InPatient, Bill: {CalculateBill()}");
    }
}

class OutPatient : Patient, IPayable
{
    private double consultationFee;

    public OutPatient(int id, string name, int age, double fee)
        : base(id, name, age)
    {
        consultationFee = fee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: OutPatient, Bill: {CalculateBill()}");
    }
}

// Doctor Class
class Doctor
{
    public string Name { get; set; }
    public string Specialization { get; set; }
}

// Main Program
class Program
{
    static void Main()
    {
        Patient p1 = new InPatient(1, "Ravi", 45, 5, 2000);
        Patient p2 = new OutPatient(2, "Sita", 30, 500);

        p1.DisplayInfo();
        p2.DisplayInfo();
    }
}
