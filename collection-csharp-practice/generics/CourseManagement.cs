using System.Collections.Generic;

abstract class CourseType
{
    public string CourseName { get; set; }
}

class ExamCourse : CourseType { }
class AssignmentCourse : CourseType { }

class Course<T> where T : CourseType
{
    public List<T> Courses = new List<T>();
}
