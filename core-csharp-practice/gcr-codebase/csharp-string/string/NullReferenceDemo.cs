class NullReferenceDemo
{
    public static void CauseException()
    {
        string text = null;
        Console.WriteLine(text.Length);
    }

    static void Main()
    {
        try
        {
            CauseException();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
        }
    }
}
