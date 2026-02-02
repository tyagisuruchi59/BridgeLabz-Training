using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        JObject o1 = JObject.Parse(@"{'name':'Suru'}");
        JObject o2 = JObject.Parse(@"{'age':22}");
        o1.Merge(o2);
        System.Console.WriteLine(o1);
    }
}
