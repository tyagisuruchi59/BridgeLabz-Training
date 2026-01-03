using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(string name, int age, string ailment, int patientId)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientId;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void DisplayPatient(object obj)
    {
        if (obj is Patient)
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
    }
}

class Program
{
    static void Main()
    {
        Patient patient = new Patient("Ravi", 35, "Fever", 9001);
        patient.DisplayPatient(patient);
        Patient.GetTotalPatients();
    }
}
