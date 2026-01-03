using System;
using System.Collections.Generic;

class Course
{
    public string CourseName { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
}

class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }
}

class School
{
    public List<Student> Students { get; set; } = new List<Student>();
}
