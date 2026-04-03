using System;

class Student
{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public string Grade;

    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void DisplayStudent(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine($"{Name} - Roll: {RollNumber}, Grade: {Grade}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Suru", 21, "A");
        s.DisplayStudent(s);
        Student.DisplayTotalStudents();
    }
}
