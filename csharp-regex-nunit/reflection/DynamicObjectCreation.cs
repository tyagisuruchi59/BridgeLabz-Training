using System;

class Student
{
    public string Name = "Suru";
}

class DynamicObjectCreation
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);

        Console.WriteLine(((Student)obj).Name);
    }
}
