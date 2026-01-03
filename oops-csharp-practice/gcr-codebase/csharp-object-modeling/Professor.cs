using System;
using System.Collections.Generic;

class Course
{
    public string CourseName { get; set; }
}

class Professor
{
    public string Name { get; set; }

    public void AssignProfessor(Course course)
    {
        Console.WriteLine($"{Name} assigned to {course.CourseName}");
    }
}

class Student
{
    public string Name { get; set; }

    public void EnrollCourse(Course course)
    {
        Console.WriteLine($"{Name} enrolled in {course.CourseName}");
    }
}
