using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name = "Suru";
    public int Age = 22;
}

class ObjectToJson
{
    static void Main()
    {
        Person p = new Person();
        Type type = p.GetType();
        StringBuilder json = new StringBuilder("{");

        foreach (var field in type.GetFields())        {
            json.Append($"\"{field.Name}\":\"{field.GetValue(p)}\",");
        }

        json.Length--;
        json.Append("}");

        Console.WriteLine(json);
    }
}
