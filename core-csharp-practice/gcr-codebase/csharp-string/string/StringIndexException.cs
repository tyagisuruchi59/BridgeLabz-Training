class StringIndexException
{
    public static void AccessInvalidIndex(string text)
    {
        Console.WriteLine(text[100]);
    }

    static void Main()
    {
        try
        {
            AccessInvalidIndex("Hello");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
        }
    }
}
