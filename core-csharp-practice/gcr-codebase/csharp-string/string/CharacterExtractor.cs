class CharacterExtractor
{
    public static char[] GetCharacters(string text)
    {
        char[] chars = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            chars[i] = text[i];
        }
        return chars;
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        char[] custom = GetCharacters(text);
        char[] builtIn = text.ToCharArray();

        Console.WriteLine("Custom Result: " + string.Join(",", custom));
        Console.WriteLine("Built-in Result: " + string.Join(",", builtIn));
    }
}
