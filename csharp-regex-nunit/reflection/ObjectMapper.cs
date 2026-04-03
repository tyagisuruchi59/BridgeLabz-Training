using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    static T ToObject<T>(Dictionary<string, object> data) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var item in data)
        {
            FieldInfo field = type.GetField(item.Key);
            if (field != null)
                field.SetValue(obj, item.Value);
        }
        return obj;
    }

    static void Main()
    {
        var dict = new Dictionary<string, object>
        {
            { "Name", "Suru" },
            { "Age", 22 }
        };

        User user = ToObject<User>(dict);
        Console.WriteLine($"{user.Name} - {user.Age}");
    }
}
