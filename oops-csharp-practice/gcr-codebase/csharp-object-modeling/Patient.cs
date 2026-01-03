using System;

class Patient
{
    public string Name { get; set; }
}

class Doctor
{
    public string Name { get; set; }

    public void Consult(Patient patient)
    {
        Console.WriteLine($"Dr. {Name} is consulting patient {patient.Name}");
    }
}

class Hospital
{
    public string HospitalName { get; set; }
}
