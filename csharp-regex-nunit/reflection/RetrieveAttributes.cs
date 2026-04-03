using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name;
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Suru")]
class Book { }

class RetrieveAttributes
{
    static void Main()
    {
        Type type = typeof(Book);
        AuthorAttribute attr = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}
