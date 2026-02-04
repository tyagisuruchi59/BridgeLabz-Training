using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("user.txt"))
            {
                Console.Write("Enter Name: ");
                writer.WriteLine("Name: " + Console.ReadLine());

                Console.Write("Enter Age: ");
                writer.WriteLine("Age: " + Console.ReadLine());

                Console.Write("Favorite Language: ");
                writer.WriteLine("Language: " + Console.ReadLine());
            }

            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
