using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        var schema = JSchema.Parse(@"{
          'type':'object',
          'properties':{
            'email':{'type':'string','format':'email'}
          }
        }");

        JObject obj = JObject.Parse(@"{'email':'test@gmail.com'}");
        System.Console.WriteLine(obj.IsValid(schema));
    }
}
