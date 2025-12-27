class ArgumentOutOfRangeDemo
{
    public static void CauseException(string text)
    {
        Console.WriteLine(text.Substring(5, -2));
    }

    static void Main()
    {
        try
        {
            CauseException("HelloWorld");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
        }
    }
}
