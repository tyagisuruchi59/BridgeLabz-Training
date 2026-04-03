using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; set; }
}

class Department
{
    public string DeptName { get; set; }
}

class University
{
    public List<Department> Departments { get; set; } = new List<Department>();
    public List<Faculty> Faculties { get; set; } = new List<Faculty>();
}
