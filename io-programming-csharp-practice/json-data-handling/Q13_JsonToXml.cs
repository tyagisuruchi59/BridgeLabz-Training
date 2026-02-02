using Newtonsoft.Json;
using System.Xml;
using System.IO;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("Input/users.json");
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");
        doc.Save("Output/users.xml");
    }
}
