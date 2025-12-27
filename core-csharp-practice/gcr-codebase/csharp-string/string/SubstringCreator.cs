class SubstringCreator
{
    public static string CreateSubstring(string text, int start, int end)
    {
        string result = "";

        for (int i = start; i <= end; i++)
        {
            result += text[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        string custom = CreateSubstring(text, start, end);
        string builtIn = text.Substring(start, end - start + 1);

        Console.WriteLine("Custom Substring: " + custom);
        Console.WriteLine("Built-in Substring: " + builtIn);
    }
}
