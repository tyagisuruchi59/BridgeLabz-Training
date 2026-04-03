using System;

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine($"ID:{patientId}, Name:{name}, Age:{age}");
    }
}

class InPatient : Patient
{
    private int days;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        this.days = days;
        dailyCharge = charge;
    }

    public override double CalculateBill() => days * dailyCharge;
}

class Program
{
    static void Main()
    {
        Patient p = new InPatient(1, "Ravi", 40, 5, 2000);
        p.GetPatientDetails();
        Console.WriteLine($"Bill: {p.CalculateBill()}");
    }
}
