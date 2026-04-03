class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    public double GetCGPA()
    {
        return cgpa;
    }
}

class PostgraduateStudent : Student
{
    public void Display()
    {
        Console.WriteLine(name);
    }
}
