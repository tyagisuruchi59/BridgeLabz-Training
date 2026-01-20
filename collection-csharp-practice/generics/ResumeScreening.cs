using System.Collections.Generic;

abstract class JobRole
{
    public string RoleName { get; set; }
}

class SoftwareEngineer : JobRole { }
class DataScientist : JobRole { }

class Resume<T> where T : JobRole
{
    public List<T> Candidates = new List<T>();
}
