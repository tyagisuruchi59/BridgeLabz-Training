using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Execute() => Console.WriteLine("Service Executed");
}

class Client
{
    [Inject]
    public Service service;
}

class SimpleDI
{
    static void Main()
    {
        Client client = new Client();

        foreach (var field in typeof(Client).GetFields())
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(client, dependency);
            }
        }

        client.service.Execute();
    }
}
